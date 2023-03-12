using System;

public class Goals
{   
    protected string x;
    
    List<string> saveList = new List<string>();
    //Save
    public void SaveGoal(List<string> goal, int points)
    {   
        saveList = goal;
        string strPoint = points.ToString();
        saveList[0] = strPoint;
        Console.Write("What would you like to name the file: ");
        string fileName = Console.ReadLine();        
        File.WriteAllLines(fileName, goal);
        

    }

    //Load
    public List<string> goalLoad(int points)
    {   
        Console.Clear();
        Console.WriteLine("What is the name of the file to open: ");
        string fileName = Console.ReadLine();
        string[] text = System.IO.File.ReadAllLines(fileName);
        List<string> textList = new List<string>();
        //Pass in the points from program.
        string checkPoints1 = points.ToString();
        //Read the first line of the txt file to see what the points are.
        
        string checkPoints2 = text[0];
        //display file
        System.Console.WriteLine($"Contents of {fileName}:");
        foreach (string line in text)
        {   
            
            if(checkPoints1 == line || checkPoints2 == line)
            {
                if(checkPoints1 == line)
                {
                    textList.Add(checkPoints1);
                }
                else if (checkPoints2 == line)
                {
                    textList.Add(checkPoints2);
                }
            }  
            else if (checkPoints1 != line || checkPoints2 != line)
            {   string[] split = line.Split(",,");
                string goalBracket = split[0];
                string goalName = split[1];
                string goalDiscription = split[2];
                string goalPoints = split[3];
                string goalComplete = split[4];
                textList.Add(goalBracket + ",," + goalName  + ",," + goalDiscription + ",," + goalPoints + ",," + goalComplete);
                Console.WriteLine($"{goalBracket} {goalName}, {goalDiscription}, {goalPoints}");
            }
        }       
        Console.WriteLine();
        return textList; 
        
    }
    
    //Name
    public string Name()
    {
        Console.WriteLine("What would like to name the goal. ");
        string goalName = Console.ReadLine();
        return goalName;
    }

    public string describeGoal()
    {
        Console.WriteLine("Describe the goal.");
        string describe = Console.ReadLine();
        return describe;
    }
    //point
    public int Point()
    {
        Console.WriteLine("How many points would you like this goal to be worth: ");
        int points = int.Parse(Console.ReadLine());
        return points;
    }


    public void displayList(List<string> display)
    {
        int counter = 0;
        foreach (string line in display)
        {   
            
            string[] split = line.Split(",,");
            string goalBracket;
            if(counter >= 1)
            {
                goalBracket = split[0];
                string goalName = split[1];
                string goalDiscription = split[2];
                string goalPoints = split[3];
                string goalComplete = split[4];
                Console.WriteLine($"{counter}. {goalBracket} {goalName}, {goalDiscription}, {goalPoints}, {goalComplete}");
                counter++;
            }
            else if(counter <= 1)
            {
                counter = 1;
                goalBracket = split[0];
                Console.WriteLine($"points: {goalBracket}");
            }
            
        }
        Console.WriteLine();
    }
    
    //record
    public virtual void Record()
    {
        
    }
}