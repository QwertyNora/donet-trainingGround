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
}