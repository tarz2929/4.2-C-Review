using System;
using System.Collections.Generic;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // In class practice:
        // Change the program to take in a list of names. Make sure the names are trimmed before they enter the list.
        // Change the GetInt() method to GetName().
        // Challenge: Prevent duplicates (case insensitive) from being added.

        // Entry point of programs in C#.
        {
            List<string> nameList = new List<string>();

            int userNumber = GetInt("Please enter an integer between 1 and 10: ", 1, 10);

            string userInput = "";
            do
            {
                userInput = GetName("Please enter a name to add to the list, or \"exit\" to exit: ");
                if (userInput != "exit")
                {
                    if (nameList.Exists(x => x.ToUpper() == userInput.ToUpper()))
                    // Exists() accepts a predicate, which is typically expressed as an arrow function (but not always).
                    // The left of the arrow is the input, and the right of the arrow is the return.
                    /*
                    static bool Anonymous(x)
                    {
                        return x.ToUpper() == userInput.ToUpper();
                    }
                    */
                    {
                        Console.WriteLine("That name is already in the list.");
                    }
                    else
                    {
                        nameList.Add(userInput);
                    }
                }
            // "Sentinel Value Loop"
            } while (userInput.ToLower() != "exit");

            // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
            foreach(string name in nameList)
            {
                Console.WriteLine(name);
            }
        }

        static string GetName(string prompt)
        {
            Console.Write(prompt);
            
            return Console.ReadLine().Trim();
        }

        static int GetInt(string prompt)
        {
            int input = 0;
            bool valid = false;
            // "Validation Loop"
            do
            {
                Console.Write(prompt);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (!valid);

            return input;
        }

        // "Overloading" a method refers to having multiple method signatures with the same name, but different parameters.
        static int GetInt(string prompt, int min, int max)
        {
            int input = 0;
            bool valid = false;
            // "Validation Loop"
            do
            {
                Console.Write(prompt);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < min || input > max)
                    {
                        throw new Exception($"The supplied value must be between {min} and {max} inclusive.");
                    }
                    valid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
            while (!valid);

            return input;
        }
    }
}
