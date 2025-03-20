public class Car(int registrationNumber)
{
    // Read-only field (Can only be set in constructor)
    private readonly int _registrationNumber = registrationNumber;

    // Required properties (Must be initialized)
    public required string Make { get; init; }
    public required string Model { get; init; }

    // Normal property
    public int Year { get; set; }

    // Protected property (accessible in derived classes)
    protected string? EngineType { get; set; }

    // Method to display car details
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Car Reg No: {_registrationNumber}, Make: {Make}, Model: {Model}, Year: {Year}");
    }
}
