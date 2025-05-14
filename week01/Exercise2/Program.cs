using System;

class Program
{
    static void Main(string[] args)
    {
        // Request a percentage grade from the user
        Console.Write("What is your grade percentage? ");
        int percent = int.Parse(Console.ReadLine());

        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent >= 50)
        {
            letter = "E";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = percent % 10;

        if (letter == "A")
        {
            if (percent < 93 && lastDigit < 3)
            {
                sign = "-"; // Only A- is allowed
            }
            else
            {
                sign = ""; // No A+ allowed
            }
        }
        else if (letter == "F")
        {
            sign = ""; // F is always just F
        }
        else
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("You have a pass mark!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}