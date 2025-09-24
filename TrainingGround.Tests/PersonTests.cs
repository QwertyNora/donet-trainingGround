using System.Net.Sockets;
using System.Reflection.Metadata;

namespace TrainingGround.Tests;

public class PersonTests
{
    private Person CreatePersonWithBirthYear(int birthYear)
    {
        return new Person(birthYear);
    }

    [Theory]
    [InlineData(1982, 2025, 43)]
    [InlineData(1992, 2025, 33)]
    [InlineData(2022, 2025, 3)]
    public void GetAgeTheory(int birthYear, int currentYear, int expectedAge)
    {
        var p = CreatePersonWithBirthYear(birthYear);

        var age = p.GetAge(currentYear);

        Assert.Equal(expectedAge, age);
    }

    [Fact]
    public void ParameterlessConstructor_CreatesPerson()
    {
        // act
        var p = new Person();

        // assert
        Assert.NotNull(p);
    }

    [Fact]
    public void Constructor_WithName_CreatesPerson()
    {
        // act
        var p = new Person("Nora");

        // assert
        Assert.NotNull(p);
        Assert.Equal("Nora", p.Name);
    }

    [Fact]
    public void APersonBornIn1972_Is53_In2025()
    {
        // arrange
        var p = CreatePersonWithBirthYear(1972);

        // act
        var age = p.GetAge(2025);

        // assert 
        Assert.Equal(53, age);
    }

    [Fact]
    public void APersonBornIn1982_Is43_In2025()
    {
        var p = CreatePersonWithBirthYear(1982);

        var age = p.GetAge(2025);

        Assert.Equal(43, age);
    }

    [Fact]
    public void APersonBornIn1992_Is33_In2025()
    {
        var p = CreatePersonWithBirthYear(1992);

        var age = p.GetAge(2025);

        Assert.Equal(33, age);
    }

    [Fact]
    public void APersonBornIn2022_Is3_In2025()
    {
        var p = CreatePersonWithBirthYear(2022);

        var age = p.GetAge(2025);

        Assert.Equal(3, age);
    }

    [Fact]
    public void AnEmployeeIsAPerson()
    {
        // act
        var emp = new Employee();
        emp.LengthInMeters = 1.95;

        // assert
        Assert.IsType<Employee>(emp);
        Assert.Equal(1.95, emp.LengthInMeters);
    }

    [Fact]
    public void AnEmployeeHasAnEmployeeId()
    {
        // act
        var emp = new Employee("Marcus", "234-BDAS");

        // assert
        Assert.IsType<Employee>(emp);
        Assert.Equal("Marcus", emp.Name);
        Assert.Equal("234-BDAS", emp.EmployeeId);
    }

    [Fact]
    public void APersonHasAnAddress()
    {

        // arrange
        var p = new Person("Marcus");

        // act
        p.Address = new Address();
        p.Address.Street = "A Street";
        p.Address.StreetNo = 23;
        p.Address.City = "Stockholm";

        // assert
        Assert.NotNull(p.Address);
        Assert.IsType<Address>(p.Address);

    }

    [Fact]
    public void AnEmployeeGetPrintString_GetsANicePrintedAddress()
    {
        // arrange
        var emp = new Employee("Marcus", "234-BDAS");
        emp.Address = new Address();
        emp.Address.Street = "A Street";
        emp.Address.StreetNo = 23;
        emp.Address.City = "Stockholm";

        // act
        var printString = emp.GetPrintString();

        // assert
        Assert.Equal(@"Marcus (234-BDAS)
        A Street 23
        Stockholm",
        printString);
    }

}