namespace TrainingGround.Tests;

public class ExceptionsTests
{
    [Fact]
    public void NotHandlingAnException()
    {
        try
        {
            // arrange 
            var i = 1;

            // act
            var result = 14 / (i - 1);
        }
        catch (System.DivideByZeroException ex)
        {
            // assert
            Assert.IsType<DivideByZeroException>(ex);
        }
    }
}