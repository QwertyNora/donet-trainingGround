public class Person
{
    private string? Name;

    //Person name constructor
    public Person(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return this.Name;
    }

    public string SetName(string nameToSet)
    {
        if (nameToSet > 5)
        {
            this.Name = nameToSet;
        }
    }
    public int BirthYear;
    public double LengthInMeters;

    //Constructor that makes Null possible
    public Person() { }
}