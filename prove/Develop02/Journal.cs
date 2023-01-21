using System.IO;
public class Journal
{
    //create file
    string myJournal = "JournalEntry.txt";

    string[] lines = System.IO.File.ReadAllLines(myJournal);


    public void AddEntry()
    {
       
        
        Console.WriteLine(PromptGenerator);
        string newEntry = Console.ReadLine();
    }
    

    public void DisplayEntry()
    {
        foreach (string line in lines)
        {
            string[] entry = line.Split(",");
        }
    }
    public void SaveEntry()
    {
        using (StreamWriter outputFile = new StreamWriter(myJournal))
        {
            outputFile.WriteLine();
        }
    }
    public void Load(){

        
    }
}