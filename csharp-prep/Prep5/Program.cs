using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    // DisplayWelcome
    static void DisplayWelcome()   
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName
    static string PromptUserName()
    {
       
        Console.Write("Enter your Name: ");
        String name = Console.ReadLine();

        return name;
    }

    // PromptUserNumber
    static int PromptUserNumber()
    {
        Console.Write("Enter favorit number: ");
        String numberEntry = Console.ReadLine();
        int number = int.Parse(numberEntry);

        return number;
    }

    // SquareNumber 
    static int SquareNumber(int number)
    {
        int squared = number * number;
        
        return squared;

    }

    // DisplayResult
    static void DisplayResult(string name, int squared)
    {
        Console.Write($"{name}, the square of your number is {squared}");  
    }
    
}