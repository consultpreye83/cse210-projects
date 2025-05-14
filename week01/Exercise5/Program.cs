using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt the user for their name and return it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Function to prompt the user for their favorite number and return it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber;
        while (!int.TryParse(Console.ReadLine(), out userNumber))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        return userNumber;
    }

    // Function to square a given number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result (user's name and the squared number)
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, your favorite number being squared is {squaredNumber}.");
    }

    static void Main()
    {
        // Calling functions in sequence and saving their return values
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
}