public class Employee{
    private static int _empCount = 0;
    protected static int IDStart;
    public int ID{get; init;}
    public required string Department{get; set;}
    public required string FullName{get; set;}
    
    static Employee(){
        IDStart = 1000;
    }
    public Employee(){
        Employee._empCount++;
        ID = Employee.IDStart++;

    }
    public static int EmployeeCount{ get => _empCount;}
    public virtual void AdjustPay(decimal percentage){}
    public override string ToString() => $"{ID} : {FullName}, {Department}";

}
public class HourlyEmp : Employee{
    public HourlyEmp(){}
    public decimal PayRate{get; set;}
    public override void AdjustPay(decimal percentage)
    {
        PayRate += (PayRate * percentage);
    }
}
public class SalariedEmp : Employee{
    public SalariedEmp(){}
    public decimal Salary{get; set;}
    public override void AdjustPay(decimal percentage)
    {
        Salary += (Salary * percentage);
    }
}