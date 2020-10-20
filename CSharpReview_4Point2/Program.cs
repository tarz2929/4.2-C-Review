using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            // Arrays in C# are fixed-length collections of items.

            // Initialize an array of length 5.
            // The first element will have index 0, second index 1, up to fifth index 4.
            int[] intArray = new int[] { 5, 3, 10, 12, 42 };

            // If we want to set it, just like most other languages, we can set an element by assigning an index.
            intArray[3] = 10;

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
