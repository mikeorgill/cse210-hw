using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for first name.
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        // Ask user for last name.
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Print the users name.
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

    }
}