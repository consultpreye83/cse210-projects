using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        int userInput;

        Console.WriteLine("Please enter some numbers to be added to the list (enter 0 to stop):");

        do
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }

        } while (userInput != 0);

        Console.WriteLine("\nYou entered the following numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // 👉 Compute sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // 👉 Compute average
        double average = 0;
        if (numbers.Count > 0)
        {
            average = (double)sum / numbers.Count;
        }

        // 👉 Find max
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // 👉 Find smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // 👉 Sort the list
        numbers.Sort();

        Console.WriteLine($"\nThe total sum is: {sum}");
        Console.WriteLine($"The average is: {average:F2}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There were no positive numbers entered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        Console.WriteLine("\nSorted list:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}