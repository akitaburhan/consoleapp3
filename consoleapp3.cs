using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 code from previous assignment (if needed, keep it here)
            string[] myArray = { "Hello", "World", "C#", "Programming" };
            Console.Write("Please enter some text to add to each array element: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] += userInput;
            }

            Console.WriteLine("\nUpdated array elements:");
            foreach (string str in myArray)
            {
                Console.WriteLine(str);
            }

            // Part 2: Fixed Infinite Loop (from previous assignment)
            Console.WriteLine("\nFixed infinite loop demonstration:");
            int counter = 0;
            while (true)
            {
                Console.WriteLine("This loop will stop after 5 iterations.");
                counter++;
                if (counter >= 5)
                {
                    break;
                }
            }

            // Part 3: Loop with "<" operator
            Console.WriteLine("\nLoop with '<' operator:");
            for (int i = 0; i < 3; i++) // This loop will run while i is less than 3
            {
                Console.WriteLine($"This is iteration {i + 1} of the '<' loop.");
            }

            // Part 3: Loop with "<=" operator
            Console.WriteLine("\nLoop with '<=' operator:");
            for (int j = 0; j <= 3; j++) // This loop will run while j is less than or equal to 3
            {
                Console.WriteLine($"This is iteration {j + 1} of the '<=' loop.");
            }

            Console.WriteLine("\nBoth loops have executed successfully.");
            Console.ReadLine(); // Keep the console open
        }
    }
}