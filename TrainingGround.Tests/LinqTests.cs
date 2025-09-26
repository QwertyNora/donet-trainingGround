namespace TrainingGround.Tests;

public class LinqTests
{
    [Fact]
    public void TestToFilterNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 20, 62, 2, 12, 17, 15, 16 };

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
        Assert.Equal(5, numbersLargerThan15.Count);

    }

    [Fact]
    public void LinqToFilterNumbers()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 20, 62, 2, 12, 17, 15, 16 };

        // act
        var numbersLargerThan15 = numbers.FindAll(number => number > 15);

        // assert
        Assert.Equal(5, numbersLargerThan15.Count);
    }

    [Fact]
    public void LinqToFindFirst()
    {
        // arrange 
        var numbers = new List<int> { 1, 53, 20, 62, 2, 12, 17, 15, 16 };

        // act
        var firstNumberLargerThan15 = numbers.Find(number => number > 15);

        // assert
        Assert.Equal(53, firstNumberLargerThan15);
    }

    [Fact]
    public void LinqToCheckIfAnyMatches()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 20, 62, 2, 12, 17, 15, 16 };

        // act
        var anyOver100 = numbers.Any(number => number > 100);

        // assert
        Assert.False(anyOver100);
    }

    [Fact]
    public void LinqToCheckIfAllMatches()
    {
        // arrange
        var numbers = new List<int> { 1, 53, 20, 62, 2, 12, 17, 15, 16 };

        // act
        var allUnder100 = numbers.All(numbers => numbers < 100);

        // assert
        Assert.True(allUnder100);
    }

    [Fact]
    public void FilterPeopleByNameLength_ReturnsCorrectList()
    {
        // arrange 
        var people = new List<Person>
        {
            new("Aaron"),
            new("Bea"),
            new("Ceasar"),
            new("Dave")
        };

        // act
        var allWithLongNames = people
        .Where(p => p.Name.Length > 4)
        .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaron", allWithLongNames[0].Name);
    }

    [Fact]
    public void FilterPeopleByNameLengthAndSelect_ReturnsCorrectList()
    {
        // arrange
        var people = new List<Person>
        {
            new("Aaron"),
            new("Bea"),
            new("Ceasar"),
            new("Dave")
        };

        // act
        var allWithLongNames = people
        .Where(p => p.Name.Length > 4)
        .Select(p => p.Name)
        .ToList();

        // assert
        Assert.Equal(2, allWithLongNames.Count);
        Assert.Equal("Aaron", allWithLongNames[0]);
        Assert.Equal("Ceasar", allWithLongNames[1]);
    }
}