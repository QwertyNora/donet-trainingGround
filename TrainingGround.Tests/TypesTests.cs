namespace TrainingGround.Tests;


public class TypesTests
{

    [Fact]
    public void ReferenceTypes_CanBeChangedViaReference()
    {
        // arrange 
        Person a = new Person("Person a", 1998, 1.95);
        Person b = a;

        // act
        b.LengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, b.LengthInMeters);
        Assert.Equal(1.96, a.LengthInMeters);

    }

    [Fact]
    public void ValueTypes_CannotBeChangedViaReference()
    {
        // arrange
        double aLengthInMeters = 1.95;
        double bLengthInMeters = aLengthInMeters;

        // act
        bLengthInMeters = 1.96;

        // assert
        Assert.Equal(1.96, bLengthInMeters);
        Assert.Equal(1.95, aLengthInMeters);
    }

    [Fact]
    public void ValueTypes_Test()
    {
        // Value types
        int x = 10;
        int y = 20;

        Console.WriteLine("init x: " + x);
        Console.WriteLine("init y: " + y);

        x = y;

        Console.WriteLine("x after x = y    x: " + x);
        Console.WriteLine("y after x = y    y: " + y);

        x++;

        Console.WriteLine("x after incremet   x: " + x);
        Console.WriteLine("y after incremet   y: " + y);
    }

    [Fact]
    public void ReferenceTypes_Test()
    {



        var p1 = new Person("Anna");
        var p2 = new Person("Oscar");

        Console.WriteLine($"P1 name: {p1.Name}");
        Console.WriteLine($"P2 name: {p2.Name}");

        p1 = p2;

        Console.WriteLine($"P1 name after p1 = p2: {p1.Name}");
        Console.WriteLine($"P2 name after p1 = p2: {p2.Name}");

        // p2.Name = "Freddy";

        Console.WriteLine($"P1 name: {p1.Name}");
        Console.WriteLine($"P2 name: {p2.Name}");


    }
}