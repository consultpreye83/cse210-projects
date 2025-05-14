using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Initialize random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // 1 to 100

        int guess = -1;
        int guessCount = 0;
        string response = "yes";
        

        Console.WriteLine("🎲 You are welcome to the Number Guessing Game!");
        Console.WriteLine("I'm thinking of a number between 1 and 100 at the moment. Do you mind guessing the number am thinking?");

        // Game loop
        while (response == "yes")
        {
            Console.Write("Guess the Magic Number: ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low. Guess Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high. Guess Lower!");
            }
            else
            {
                Console.WriteLine($" Correct! You guessed it in {guessCount} tries.");
                Console.WriteLine("do you want to continue playing the guessing game? ");
                response = (Console.ReadLine());
            }
        }
    }
}