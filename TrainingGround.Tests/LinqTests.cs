namespace TrainingGround.Tests;

public class LinqTests
{
    [Fact]
    public void TestToFilterNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numQuery = from num in numbers
                       where num > 15
                       select num;

        var numbersLargerThan15 = numQuery.ToList();

        foreach (var number in numbersLargerThan15)
        {
            Console.WriteLine(number);
        }


        // assert
        Assert.Equal(4, numbersLargerThan15.Count);

    }

    [Fact]
    public void LinqToFilterNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 2, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(4, numbersLargerThan15.Count);
    }
}