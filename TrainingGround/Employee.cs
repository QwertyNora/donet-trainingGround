namespace TrainingGround;

public class Employee : Person
{
    public string EmployeeId { get; set; }

    public Employee() { }
    public Employee(string name, string employeeID) : base(name)
    {
        this.EmployeeId = employeeID;
    }
}