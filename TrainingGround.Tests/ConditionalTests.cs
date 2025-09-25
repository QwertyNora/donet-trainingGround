namespace TrainingGround.Tests;

public class ConditionalTests
{

    [Fact]
    public void ShouldBeKid_WhenYoungerThan18()
    {
        // arrange
        var p = new Person(2005);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Kid, category);
    }

    [Fact]
    public void ShouldBeAdult_WhenOlderThan18()
    {
        // arrange 
        var p = new Person(2002);

        // act
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Adult, category);
    }

    [Fact]
    public void ShouldBePrimeAge_When50()
    {
        // arrange
        var p = new Person(1972);

        // act 
        var category = AgeCalculator.GetAgeCategory(p, 2022);

        // assert
        Assert.Equal(AgeCategory.Prime, category);
    }

    [Fact]
    public void ShouldReturnUnder18_WhenKid()
    {
        // act
        var span = AgeCalculator.GetAgeSpan(AgeCategory.Kid);

        // assert
        Assert.Equal("Under 18 years", span);
    }

    [Theory]
    [InlineData(AgeCategory.Kid, "Under 18 years")]
    [InlineData(AgeCategory.Adult, "Above 18")]
    [InlineData(AgeCategory.Prime, "Exactly 50 - and proud!")]
    public void GetSpanTheory(AgeCategory _category, string expectedSpan)
    {
        // act
        var span = AgeCalculator.GetAgeSpan(_category);

        // assert
        Assert.Equal(expectedSpan, span);
    }


}