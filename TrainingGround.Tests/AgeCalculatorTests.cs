namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    [Fact]
    public void SomeoneBornIn1972_Is50_In2022()
    {
        // arrange 
        var calculator = new AgeCalculator();

        // act 
        var age = calculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);
    }
}
