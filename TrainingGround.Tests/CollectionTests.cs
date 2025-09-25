namespace TrainingGround.Tests;

public class CollectionTests
{
    [Fact]
    public void ArrayLength_ReturnsCorrectValue()
    {
        // act
        var arrayOfIntegers = new int[5];
        var arrayOfIntegersWithValues = new int[] { 1, 2, 3 };
        var arrayOfStrings = new string[] { "Name 1", "Name 2" };

        // assert
        Assert.Equal(5, arrayOfIntegers.Length);
        Assert.Equal(3, arrayOfIntegersWithValues.Length);
        Assert.Equal(2, arrayOfStrings.Length);
    }

}