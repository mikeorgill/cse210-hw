using System;

class Program
{
    static void Main(string[] args)
    {

        Goals goals = new Goals();
        SimpleGoal simple = new SimpleGoal();
        EnternalGoal enternal = new EnternalGoal();
        CheckGoal check = new CheckGoal();

        List<string> goalList = new List<string>();
        
        string s0 = "[ ]";
        string s1;
        string s2;
        string s3;
        string s4 = "True";
        int int1;
        int pointCount;
        int totalPoints = 0;
       
        string menu;
        int menuChoice = 0;
        Console.Clear();
        while(menuChoice != 6)
        {   
            Console.WriteLine($"You Have: {totalPoints} points.");
            Console.WriteLine("\n1. Create Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Goals \n6. Quit");
            Console.Write("\nWhat would you like to do: ");
            menu = Console.ReadLine();
            menuChoice = int.Parse(menu); 
            Console.WriteLine();
            
            if(menuChoice == 1)
            {
                int i = 0;
                while (i != 4)
                {   
                    Console.WriteLine("What type of Goal would you like to create: ");
                    Console.WriteLine("1. Simple Goal.\n2. Eternal Goal.\n3. Check list Goal.\n4. Quit.");
                    string u1 = Console.ReadLine();
                    int userGoalChoice = int.Parse(u1);

                    if(userGoalChoice == 1)
                    {
                        //Call simple goal
                        s1 = simple.getName();
                        s2 = simple.getDescribeGoal();
                        int1 = simple.getPoint();
                        s3 = int1.ToString();
                        s4 = "False";
                        goalList.Add(s0 + ",," + s1 +",," + s2 + ",," + s3 + ",," +s4);
                                              
                        i = 0;
                        
                    }
                    else if (userGoalChoice == 2)
                    {
                        //Call Eternal goal
                        //Call simple goal
                        s1 = enternal.getName();
                        s2 = enternal.getDescribeGoal();
                        int1 = enternal.getPoint();
                        s3 = int1.ToString();
                        
                        goalList.Add(s0 + ",," + s1 +",," + s2 + ",," + s3 + ",," + s4);
                                              
                        i = 0;
                    }
                    else if (userGoalChoice == 3)
                    {
                        //Call check goal
                        //Call Eternal goal
                        //Call simple goal
                        s1 = check.getName();
                        s2 = check.getDescribeGoal();
                        int1 = check.getPoint();
                        s3 = int1.ToString();
                        
                        goalList.Add(s0 + ",," + s1 +",," + s2 + ",," + s3 + ",," + s4);

                    }
                    else
                        i = 4;

                
                }
                
            }
            else if (menuChoice == 2)
            {
                //Call stored list of goals.
                goals.displayList(goalList);
            }
            //Call Goals save method.
            else if (menuChoice == 3)
            {
                goals.SaveGoal(goalList, totalPoints);          

            }
            //Call Goals load method.
            else if (menuChoice == 4)
            {   
                List<string> loadList = new List<string>();
                loadList = goals.goalLoad(totalPoints);
                foreach(string list in loadList)
                {
                    goalList.Add(list);
                }
                //Console.WriteLine("Test Load");
                //goals.displayList(goalList);
                string newTotalPoints = goalList[0];
                totalPoints = int.Parse(newTotalPoints);
            }
            //Call Goal record to mark the goal.
            else if (menuChoice == 5)
            {   //counter will equal line number on txt file.
                goals.displayList(goalList);
                Console.WriteLine("Which goal would you like to update: ");
                string userInput2 = Console.ReadLine();
                int u2 = int.Parse(userInput2);
                int userSelection = u2;
                //Console.WriteLine(userSelection);
                string checkGoalSelection = goalList[userSelection];
                string[] checkIfFalse = checkGoalSelection.Split(",,");
                string index0 = "[ ]";
                string index1 = checkIfFalse[1];
                string index2 = checkIfFalse[2];
                string index3 = checkIfFalse[3];
                string index4 = checkIfFalse[4];
                //string index5 = checkIfFalse[5];
                //Console.WriteLine(checkIfFalse[4]);
                if(index4 == "False")
                {
                    index0 = "[X]";
                    index4 = "True";                 
                    simple.Record();
                    pointCount = int.Parse(index3);
                    totalPoints += pointCount;
                    goalList.RemoveAt(userSelection);
                    goalList.Add(index0 +",," + index1 +",,"+ index2 +",," + index3 +",," + index4);
                }
                else if (index4 == "True")
                {   
                    Console.WriteLine("Nice job keeping on doing this goal.");
                    pointCount = int.Parse(index3);
                    totalPoints += pointCount;
                }
                /*else if (index4 == "False" && index5 != null)
                {
                    pointCount = int.Parse(index3);
                    totalPoints += pointCount;
                    //index5 = "x";
                }*/


            }

            else
                menuChoice = 6;
       } 

        foreach(string goal in goalList)
        {
            Console.WriteLine($"The Goal List is: {goal}");
        }
        
        Console.WriteLine("Nice work today lets keep working on those goals.");
        Console.WriteLine("You can do it! \nLets complete all your goals.");

    }
}