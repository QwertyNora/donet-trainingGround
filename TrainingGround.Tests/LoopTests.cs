using System.Runtime.InteropServices.Marshalling;

namespace TrainingGround;

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

            Console.WriteLine($"i is now {i}");
            Console.WriteLine($"currentValueInTheLoop is now {currentValueInTheLoop}");

            // assert
            Assert.Equal(i + 1, currentValueInTheLoop);
        }


    }
}