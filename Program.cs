using System;

namespace OddEvenSorter
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
            

            /*
                variables: inputArray, oddArray, evenArray

                explain purpose prompt
                while the array is not full (10), and done is not entered
                    while the input is not valid
                        prompt for an integer, and add the integer to the array
                for each item in the array
                    if the item is even:
                        add it to even array
                    else:
                        add it to odd array
                sort each array (odd and even) between start and the number of elements we copied in
                copy the elements from odd into the output
                copy the elements from even into the output



                function SortPartialArray (array, start, end) {
                    bubble sort from start to end
                }
            */
            
            // The size we declare the array as "physical size" is the maximum number of things we can store (size of the shelf).
            int[] inputArray = new int[10], oddArray = new int[10], evenArray = new int[10];
            // The "logical" size is the number of things in the array that we actually care about (number of boxes on the shelf).
            // When we output we can go from 0 to the logical size and we won't output a bunch of 0's, or data that was "deleted". 
            int inputArrayLogical = 0, oddArrayLogical = 0, evenArrayLogical = 0;
            string userInput;

            Console.WriteLine("This application will take in some numbers, and sort them in order but with odd numbers first, then even numbers.");


            
            do
            {
                
                int userInputInt;

                Console.Write("Please enter a integer, or \"done\" to output.");
                userInput = Console.ReadLine(); 
                
                try
                {
                    // If this parse fails, none of the rest of the try block will execute, meaning we won't add garbage data
                    // to our array, and the logical size will not go up.
                    userInputInt = int.Parse(userInput);

                    // Order of the next two lines is important because logical size serves as the index of the next available spot.
                    inputArray[inputArrayLogical] = userInputInt;
                    inputArrayLogical++;
                }
                catch
                {
                    // If the user has entered "done", the try will still fail, but because it's valid for our program,
                    // we don't want to tell the user they entered something bad.
                    if (userInput.ToLower().Trim() != "done")
                    {
                        Console.WriteLine("You entered invalid input, please try again.");
                    }
                }
            // While the array is not full (number of things we care about is less than max things)
            // (number of boxes on shelf is less than size of shelf), and the user has not entered
            // the sentinel value.
            } while(inputArrayLogical < inputArray.Length && userInput.ToLower().Trim() != "done");
        }
    }
}
