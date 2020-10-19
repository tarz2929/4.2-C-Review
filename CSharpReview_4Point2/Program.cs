using System;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // Entry point of programs in C#.
        {
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


            string name;

            // Write a prompt.
            // Write will keep the cursor on the same line, WriteLine will not.
            Console.Write("Please enter your name: ");

            // Input from the console.
            // Trim() will remove all leading and trailing whitespace (newlines, spaces, tabs, etc).
            name = Console.ReadLine().Trim();

            // Condition is an expression that evaluates to either true or false. 
            // True runs the "if" side, false runs the "else" side.

            // Roughly equivalent to name == "", except it also treats null as empty, and any whitespace.
            // Whitespace should be already trimmed, but the extra layer doesn't necessarily hurt.
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Invalid Input: Please enter a name.");
            }
            else if (name == "Admin")
            {
                Console.WriteLine("Administrative access granted.");
            }
            else
            {
                // Output to the console.
                // Concatenation.
                Console.WriteLine("Hello " + name + "! What a nice day today!");
                // Parameterized Output.
                Console.WriteLine("Hello {0}! What a nice day today!", name);
                // String Interpolation.
                Console.WriteLine($"Hello {name}! What a nice day today!");
            }
            

            // Exit point of programs in C#.
        }
    }
}
