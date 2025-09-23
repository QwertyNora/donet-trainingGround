namespace TrainingGround.Tests;

public class AgeCalculatorTests
{
    private AgeCalculator _calculator;

    public AgeCalculatorTests()
    {
        _calculator = new AgeCalculator();
    }

    [Fact]
    public void SomeoneBornIn1972_Is50_In2022()
    {

        // act 
        var age = AgeCalculator.GetAge(1972, 2022);

        // assert
        Assert.Equal(50, age);
    }

    [Fact]
    public void SomeoneBornIn2022_Is0_In2022()
    {

        // act
        var age = AgeCalculator.GetAge(2022, 2022);

        // assert
        Assert.Equal(0, age);
    }
}
