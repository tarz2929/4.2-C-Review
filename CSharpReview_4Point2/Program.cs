using System;
using System.Collections.Generic;

namespace CSharpReview_4Point2
{
    class Program
    {
        static void Main(string[] args)
        // In class practice:
        // Combine the two list programs we've looked at. Prompt for both a name, and an age (between 1 and 100), until the name entered is "exit" (case insensitive).
        // Once exited, output "$name is $age years old." for each stored person.
        // Hint: You'll need multiple arrays.
        // Challenge: Create a class/object to store the name and age, and use only one list.

        // Entry point of programs in C#.
        {
            List<string> nameList = new List<string>();
            List<int> ageList = new List<int>();

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
                        ageList.Add(GetInt($"Please enter the age for {userInput}: ", 1, 100));
                    }
                }
            // "Sentinel Value Loop"
            } while (userInput.ToLower() != "exit");

            // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
            for (int i = 0; i < nameList.Count; i++)
            {
                Console.WriteLine($"{nameList[i]} is {ageList[i]} years old.");
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
