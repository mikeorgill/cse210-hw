using System.IO;
public class Journal
{
    string filePath = @"cse210-hw\prove\Develop02\journalLog.txt";
    public string _addEntry;
    
    public string _loadFile;

    public string _saveFile(){
          closeFile = new System.IO.File.(filePath);
        
    }
    //create file or open file
    public void _openJournal(){
        
        string[] journalLog;
        

            if (File.Exists(filePath)){
                string[] lines = System.IO.File.ReadAllLines(filePath);
                journalLog = lines;
            }

            else{
                FileStream log = File.Create(filePath);
                string[] lines = System.IO.File.ReadAllLines(filePath);
                journalLog = lines;        
        
            }
    }
    
}