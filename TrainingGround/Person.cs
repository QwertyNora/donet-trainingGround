
using TrainingGround;

public class Person : IPrintable
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double LengthInMeters { get; set; }
    public Address? Address { get; set; }

    public Person(string name)
    {
        this.Name = name;
    }

    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }

    public Person() { }

    public Person(string name, int birthYear, double lengthInMeters)
    {
        this.Name = name;
        this.BirthYear = birthYear;
        this.LengthInMeters = lengthInMeters;
    }

    public void UpdateLength(double newLength)
    {
        this.LengthInMeters = newLength;
    }

    public int GetAge(int currentYear)
    {
        var age = currentYear - this.BirthYear;
        if (age < 0)
        {
            throw new Exception("Not born yet.");
        }
        return age;
    }

    public string GetPrintString()
    {
        return @$"{this.Name} lives at:
        {this.Address.Street} {this.Address.StreetNo}, {this.Address.City}.";
    }
}