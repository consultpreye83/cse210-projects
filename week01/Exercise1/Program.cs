using System;

class Program
{
    static void Main(string[] args)
    {
        // interact with the user by asking for their name.
        Console.Write("What is your first name? ");
        String First = Console.ReadLine ();

        Console.Write("What is your Last Name? ");
        string Last = Console.ReadLine();

        Console.WriteLine($"Your name is {Last}, {First} {Last}");
    }
}