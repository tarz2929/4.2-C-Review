using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
            // In-Class Exercise: 
            // Make the "Admin" decision branch case-insensitive.
            
            // Declaration of a variable.
            char aChar; // A single character value.
            string aString; // String (collection of characters) values.

            bool aBoolean; // Boolean (true-false) values (bit).

            byte aByte; // Super small integer values (~120 max).
            short aShortInt; // Small integer values (~65000 max).
            int anInt; // Integer values (~210000000 max).
            long aLongInt; // BIG integer values (9223372036854775807 max).

            float aFloat; // Floating point values (less precision than doubles).
            double aDouble; // Decimal values (like a float but more precise).
            decimal aDecimal; // Also decimal values (extremely precise).


            int userInput;
            string output;

            Console.Write("Please enter a number: ");

            // int.Parse is "dangerous" because it can throw an exception.
            userInput = int.Parse(Console.ReadLine());

            // Switch works with discrete values, not ranges like if allows, but some people find it more readable.
            // Anything* you can do with a switch, you can do with an if/else.
            // * Falling through cases is questionable with if/else as you need some other logic, but it's questionable whether
            // that should be done anyways.

            switch (userInput % 2)
            {
                case 0:
                    output = "even";
                    break;
                case 1:
                    output = "odd";
                    break;
                default:
                    output = "error";
                    break;
            }

            Console.WriteLine($"The number entered is {userInput}, it is {output}.");


            // Exit point of programs in C#.
        }
    }
}
