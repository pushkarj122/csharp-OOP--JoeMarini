//base class
public class Person{
    private int age;
    public string Name{get; set;}

    //protected property but accessible in derived class
    protected string Address{get; set;}
    
    //property with validation in setter
    public int Age{
        get {return age;}
        set{
            if(value > 0){
                age = value;
            }
            else{
                age = 0;
            }
        }
    }
    public Person (string name, int age, string address){
        Name = name;
        Age = age;
        Address = address;
    }
    public void DisplayInfo(){
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}