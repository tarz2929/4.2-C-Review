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

            Console.Write("Please enter a number to count to: ");

            // int.Parse is "dangerous" because it can throw an exception.
            userInput = int.Parse(Console.ReadLine());


            // Initialize, Test, Process, Modify

            // Pre-Test Loops. Do not run at all if the condition is false.
            for (int x = 1 /* Initialize */ ; x <= userInput /* Test  */; x++ /* Modify */)
            {
                // Process
                Console.WriteLine(x);
            }
       
            int y = 1; // Initialize
            while (y <= userInput) // Test
            {
                Console.WriteLine(y); // Process
                y++; //Modify
            }


            // Post-Test Loop. Always runs at least once, even if the condition is false.
            int z = 1; // Initialize
            do
            {
                Console.WriteLine(z); // Process
                z++; // Modify
            }
            while (z <= userInput); // Test
            // Exit point of programs in C#.
        }
    }
}
