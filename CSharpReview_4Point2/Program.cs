using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            int[] intArray = new int[GetInt("Please enter a number of integers to store: ")];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = GetInt($"Please enter integer #{i + 1}: ");
            }

            // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
            foreach(int integer in intArray)
            {
                Console.WriteLine(integer);
            }
        }

        /*
            static: Tells C# to only keep one copy of the method in memory (important for OOP).
            int: Return type, the type of data coming out of the method.
            GetInt: Name of the method, how we call it.
            string: First parameter type, the type of input expected.
            prompt: First parameter/argument name, how we refer to that value in the method.
        */
        static int GetInt(string prompt)
        {
            int input;

            Console.Write(prompt);
            input = int.Parse(Console.ReadLine());

            return input;
        }
    }
}
