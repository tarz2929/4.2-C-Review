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

            string userInput = "";
            do
            {
                userInput = GetName("Please enter a name to add to the list, or \"exit\" to exit: ");
                if (userInput != "exit")
                {
                    nameList.Add(userInput);
                }
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
    }
}
