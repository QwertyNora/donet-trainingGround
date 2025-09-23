
public class Person
{
    public string? Name { get; private set; }
    public int BirthYear { get; private set; }
    public double LengthInMeters { get; private set; }

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

    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
}