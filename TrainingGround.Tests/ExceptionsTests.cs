namespace TrainingGround.Tests;

public class ExceptionsTests
{
    [Fact]
    public void NotHandlingAnException()
    {
        // arrange
        var i = 1;

        // act
        var result = 14 / (i - 1);
    }
}