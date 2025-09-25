using System.Runtime.InteropServices.Marshalling;

namespace TrainingGround.Tests;

public class LoopTests
{
    [Fact]
    public void WhileLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        var i = 0;
        while (i < ints.Length)
        {
            var currentValueInTheLoop = ints[i];

            // Console.WriteLine($"i is now '{i}'");
            // Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);

            i = i + 1;
        }
    }

    [Fact]
    public void ForLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };

        // act
        for (var i = 0; i < ints.Length; i++)
        {
            var currentValueInTheLoop = ints[i];

            // Console.WriteLine($"i is now {i}");
            // Console.WriteLine($"currentValueInTheLoop is now {currentValueInTheLoop}");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }


    }

    [Fact]
    public void ForEachLoop()
    {
        // arrange
        var ints = new int[] { 1, 2, 3, 4, 5 };
        int i = 0;

        // act
        foreach (var currentValueInTheLoop in ints)
        {
            Console.WriteLine($"i is now '{i}'");
            Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");
            i++;
            // assert
            Assert.IsType<int>(currentValueInTheLoop);
        }
    }

    [Fact]
    public void ForEachLoopOverAddresses()
    {
        // arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        // act
        foreach (var currentValueInTheLoop in addressList)
        {
            Console.WriteLine($"StreetNo is now '{currentValueInTheLoop.StreetNo}'");

            // assert
            Assert.IsType<Address>(currentValueInTheLoop);
        }
    }

    [Fact]
    public void BreakStopsLoops()
    {
        // arrange
        var addressList = new List<Address>();
        addressList.Add(new Address() { Street = "Street", StreetNo = 1 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 2 });
        addressList.Add(new Address() { Street = "Street", StreetNo = 3 });

        // act
        var foundIt = false;
        foreach (var currentValueInTheLoop in addressList)
        {
            if (currentValueInTheLoop.StreetNo == 2)
            {
                foundIt = true;
                break; // stop iterating over the list altogether; continue at the assertion
            }
        }

        // assert
        Assert.True(foundIt);
    }
}