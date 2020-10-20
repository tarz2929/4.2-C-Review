using System;
using System.Collections.Generic;

namespace CSharpReview_4Point2
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

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
            List<Person> personList = new List<Person>();

            string userInput = "";
            do
            {
                Person toAdd = new Person();
                userInput = GetName("Please enter a name to add to the list, or \"exit\" to exit: ");
                if (userInput != "exit")
                {
                    if (personList.Exists(x => x.Name.ToUpper() == userInput.ToUpper()))
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
                        toAdd.Name = userInput;
                        toAdd.Age = GetInt($"Please enter the age for {userInput}: ", 1, 100);
                        personList.Add(toAdd);
                    }
                }
            // "Sentinel Value Loop"
            } while (userInput.ToLower() != "exit");

            // foreach will loop over every item in a collection, however they are typically treated as readonly (with "normal" data types anyways).
            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.Name} is {person.Age} years old.");
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
