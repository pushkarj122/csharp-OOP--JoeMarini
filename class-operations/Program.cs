using System;

class Program
{
    static void Main()
    {
        // Object Initializer with required and init-only properties
        ElectricCar myEV = new ElectricCar(12345)
        {
            Make = "Tesla",
            Model = "Model S",
            Year = 2023,
            BatteryCapacity = 100
        };

        // Display car details
        myEV.DisplayCarInfo();
        myEV.DisplayElectricCarInfo();

        // Anonymous Type example
        var anonymousCar = new
        {
            Make = "Nissan",
            Model = "Leaf",
            Year = 2022,
            BatteryCapacity = 62
        };

        Console.WriteLine($"Anonymous Electric Car: {anonymousCar.Make} {anonymousCar.Model}, Battery: {anonymousCar.BatteryCapacity} kWh, Year: {anonymousCar.Year}");
    }
}
