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


}