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

    [Fact]
    public void ShouldGetItemsOut_WhenAccessingIndex()
    {
        // act
        var arrString = new string[] { "Name 1", "Name 2" };

        // assert
        Assert.Equal("Name 1", arrString[0]);
        Assert.Equal("Name 2", arrString[1]);
    }

    [Fact]
    public void ObjectInitializerWorks()
    {
        // act
        var a = new Address();
        a.Street = "B Street";
        a.StreetNo = 22;
        a.City = "Malmö";

        var b = new Address
        {
            Street = "B Street",
            StreetNo = 22,
            City = "Malmö"
        };

        // assert
        Assert.Equal(a.Street, b.Street);
        Assert.Equal(a.StreetNo, b.StreetNo);
        Assert.Equal(a.City, b.City);
    }

    [Fact]
    public void AListOfIntegersIsVeryFlexible()
    {
        // arrange
        var integerList = new List<int>();

        // act
        integerList.Add(1);
        integerList.Add(2);
        integerList.Add(3);
        integerList.RemoveAt(0);

        // assert
        Assert.Equal(2, integerList.Count);
        Assert.Equal(2, integerList[0]);
        Assert.Equal(3, integerList[1]);
    }

    [Fact]
    public void ListsCanHoldAnything()
    {
        // arrange
        var intList = new List<int>();
        var stringList = new List<string>();
        var addressList = new List<Address>();

        // act
        intList.Add(1); intList.Add(2); intList.Add(3);
        stringList.Add("1"); stringList.Add("2"); stringList.Add("3");
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        // assert
        Assert.IsType<int>(intList[0]);
        Assert.IsType<string>(stringList[0]);
        Assert.IsType<Address>(addressList[0]);
        Assert.IsNotType<int>(addressList[0]);
    }

    [Fact]
    public void AnEmployeeHasMoreThanOnAddress()
    {
        // arrange
        var emp = new Employee("Marcus", "DBSAS-1253");

        // act
        emp.Addresses.Add(new Address() { Street = "Work Street", StreetNo = 2, City = "Stockholm" });
        emp.Addresses.Add(new Address() { Street = "Vacation Street", StreetNo = 2, City = "Honolulu" });

        // assert
        Assert.Equal(2, emp.Addresses.Count);

    }

}