Employee e = new Employee("John Doe", 30, "AECS Layout" ,"Engineering");

//accessing public properties
e.DisplayInfo();
e.DisplayEmpInfo();

//using anonymous type
var anonPerson = new {
    Name = "Pushkar",
    Age  = 25,
    Address = "42 Avenue, LA"
};
//display anon type properties
Console.WriteLine($"Anon Person : {anonPerson.Name}");