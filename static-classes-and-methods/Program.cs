var E1 = new HourlyEmp(){FullName = "Pushkar Jha", Department = "Engineering", PayRate = 500.0m };
var E2 = new SalariedEmp(){FullName = "John Doe", Department = "Finance", Salary = 1000.0m };

Console.WriteLine($"Count: {Employee.EmployeeCount}");
var E3 = new SalariedEmp(){FullName = "Leo Messi", Department = "Sales", Salary = 950.0m };
Console.WriteLine($"Count: {Employee.EmployeeCount}");


Console.WriteLine($"{E1}");
Console.WriteLine($"{E2}");
Console.WriteLine($"{E3}");
