using System;

class Program
{
    static void Main(string[] args)
    {   
        //string word = Reference._reference();
        string word = Words.randomVerse;
        List<string> wordList = new List<string>();
        wordList.AddRange(word.Split(" "));
        string choice = " ";
        while(choice != "quit"){
            Console.Write("Press enter to remove random words or type quit to end: ");
            choice = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(word);
            Console.WriteLine(wordList);
            
            Console.WriteLine("Code was here:");
        }
            
        //Console.Clear();
        //Console.WriteLine($"here is the wordList: {wordList}");
        Console.WriteLine("Thank for ending the program");
    }
}