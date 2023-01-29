class Program
{  
    static void Main(string[] args)
    {   
        Journal myJournal = new Journal();
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();

            Console.WriteLine("What would you like to do today.");
            Console.WriteLine("1. Write:\n2 save:\n3 Load:");
            int slectionMade = int.Parse(Console.ReadLine());
        
            // Get a prompt from the PromptGenerator.
            string entryPrompt = prompt._randomPrompt();
            string newEntry = "";
            
            if (slectionMade == 1){
                Console.Write(entryPrompt);
                newEntry = Console.ReadLine();
            }

            else if (slectionMade == 2){
                if (newEntry != null){
                    myJournal._addEntry(newEntry);
                }
                else{
                    Console.Write("Nothing to save.");
                }
            }       
        
        
        string newJournal = journal._addEntry();

        

    }
}