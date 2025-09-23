using System.Reflection.Metadata;

namespace TrainingGround.Tests;

public class PersonTests
{
    private Person CreatePersonWithBirthYear(int birthYear)
    {
        return new Person(birthYear);
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
        var p = new Person(1972);

        // act
        var age = p.GetAge(2025);

        // assert 
        Assert.Equal(53, age);
    }

    [Fact]
    public void APersonBornIn1982_Is43_In2025()
    {
        var p = new Person(1982);

        var age = p.GetAge(2025);

        Assert.Equal(43, age);
    }

    [Fact]
    public void APersonBornIn1992_Is33_In2025()
    {
        var p = new Person(1992);

        var age = p.GetAge(2025);

        Assert.Equal(33, age);
    }

    [Fact]
    public void APersonBornIn2022_Is3_In2025()
    {
        var p = new Person(2022);

        var age = p.GetAge(2025);

        Assert.Equal(3, age);
    }

    [Fact]
    public void PersonBornYearX_IsX_YearsOldCurrentYear()
    {

    }
}