public class Employee: Person{
    //property specific to employee
    public string Department{get; set;}
    //constructor calling the base class constructor
    public Employee(string name, int age, string address, string department): base(name , age, address){
        Department = department;
    }
    //overriding
    public void DisplayEmpInfo(){
        Console.WriteLine($"Employee : {Name}, Age : {Age}, Department : {Department}");
    }
}