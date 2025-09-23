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
}