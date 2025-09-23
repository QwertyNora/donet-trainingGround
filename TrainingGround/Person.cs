public class Person
{
    public string? Name { get; private set; }

    //Person name constructor
    public Person(string name)
    {
        this.Name = name;
    }

    public int BirthYear;
    public double LengthInMeters;

    //Constructor that makes Null possible
    public Person() { }
}