using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Title: Odd/Even Sorter
                Purpose: Sort an array with the odd numbers first, then the even numbers.

                Author: James Grieve
                Last Modified: August 14, 2020
            */


            List<int> numbers = new List<int>(), output = new List<int>();

            Console.WriteLine("This application will take in some numbers, and sort them in order but with odd numbers first, then even numbers.");

            PopulateInput(numbers);

            // IEnumerable is kinda like a list, sorta, sometimes.
            IEnumerable<int> evens = numbers.Where(x => x % 2 == 0).OrderBy(x => x);
            /*
            (x => x % 2 == 0)

            Is a shorthand way of writing something like this:

            static bool anonymous(int x)
            {
                return x % 2 == 0;
            }
            */

            IEnumerable<int> odds = numbers.Where(x => x % 2 == 1).OrderBy(x => x);

            output.AddRange(odds.ToList());
            output.AddRange(evens.ToList());

            Output(output);


        } // This should be the ONLY point in the program that your program exits.

        static void PopulateInput(List<int> inputStore)
        {
            string userInput;
            do
            {
                Console.Write("Please enter a integer, or \"done\" to output: ");
                userInput = Console.ReadLine();

                try
                {
                    inputStore.Add(int.Parse(userInput));
                }
                catch
                {
                    if (userInput.ToLower().Trim() != "done")
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }
            } while (userInput.ToLower().Trim() != "done");
        }


        static void Output(List<int> theList)
        {
            //Console.WriteLine($"You entered {oddCount} odd numbers and {evenCount} even numbers.");
            for (int i = 0; i < theList.Count; i++)
            {
                Console.WriteLine(theList[i]);
            }
        }
    }
}
