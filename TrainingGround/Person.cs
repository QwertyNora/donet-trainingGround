
public class Person
{
    // Name property, private set
    public string? Name { get; private set; }

    //Person Name constructor
    public Person(string name)
    {
        this.Name = name;
    }

    // BirthYear property, private set
    public int BirthYear { get; private set; }

    // Person BithYear constructor
    public Person(int birthYear)
    {
        this.BirthYear = birthYear;
    }
    public double LengthInMeters;

    // Constructor to initialize both name, birth year and length
    public Person(string name, int birthYear, double lengthInMeters)
    {
        this.Name = name;
        this.BirthYear = birthYear;
        this.LengthInMeters = lengthInMeters;
    }

    //Constructor that makes Null possible
    public Person() { }

    // Get Persons age method
    public int GetAge(int currentYear)
    {
        return currentYear - this.BirthYear;
    }
}