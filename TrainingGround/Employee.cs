namespace TrainingGround;

public class Employee : Person, IPrintable
{
    public string EmployeeId { get; set; } = string.Empty;
    public List<Address> Addresses { get; set; }

    public Employee(string name, string employeeID) : base(name)
    {
        this.Addresses = new List<Address>();
        this.EmployeeId = employeeID;
    }

    public Employee()
    {
        this.Addresses = new List<Address>();
    }

    public string GetPrintString()
    {
        return @$"{this.Name} ({this.EmployeeId})
        {this.Address.Street} {this.Address.StreetNo}
        {this.Address.City}";
    }
}