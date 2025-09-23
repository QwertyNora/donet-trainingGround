namespace TrainingGround.Tests;

public class PersonTests
{
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
    public void APersonBornIn1972_Is50_In2022()
    {
        // arrange
        var p = new Person();
        p.BirthYear = 1972;

        // act
        var age = p.GetAge(2022);

        // assert 
        Assert.Equal(50, age);
    }
}