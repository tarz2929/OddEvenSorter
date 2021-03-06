﻿using System;
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


            List<int> numbers = new List<int>();

            Console.WriteLine("This application will take in some numbers, and sort them in order but with odd numbers first, then even numbers.");

            PopulateInput(numbers);
            
            numbers = Enumerable.Concat(
                numbers.Where(x => x % 2 == 1).OrderBy(x => x), 
                numbers.Where(x => x % 2 == 0).OrderBy(x => x)
            ).ToList();

            Output(numbers);

        }

        static void PopulateInput(List<int> inputStore)
        {
            string userInput;
            do
            {
                int userInputInt;
                Console.Write("Please enter an integer: ");
                userInput = Console.ReadLine().Trim();

                if (userInput.ToLower() != "done")
                {
                    if (!int.TryParse(userInput, out userInputInt))
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                    else 
                    {
                        inputStore.Add(userInputInt);
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
