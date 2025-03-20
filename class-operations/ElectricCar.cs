public class ElectricCar : Car
{
    // Init-only property (Can only be set during initialization)
    public int BatteryCapacity { get; init; }

    // Constructor calling base class constructor
    public ElectricCar(int registrationNumber) : base(registrationNumber)
    {
        EngineType = "Electric";
    }

    // Method to display electric car details
    public void DisplayElectricCarInfo()
    {
        Console.WriteLine($"Electric Car: {Make} {Model}, Battery: {BatteryCapacity} kWh, Engine: {EngineType}");
    }
}
