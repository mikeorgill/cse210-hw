using System;
//Timer, countdown timer, spinning timer   

class BaseActivity
{
    
    private string userInput;
    private int time;
    
    public int Timer()
    {   
        Console.WriteLine("How much time do you want for this activity in seconds: ");
        userInput = Console.ReadLine();
        time = int.Parse(userInput);
        return time;
        
    }

    public void CountdownTimer()
    {
        int i = 3;
        while (i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            //if(i <= 10){
                //Console.Write("\b\b  \b\b");
            //}
            //else
            Console.Write("\b \b");

            i--;
        }
    }
    public void SpinningTimer()
    {   
        int i = 0;
        int j = 0;
        List<string> spinner = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        while (i < 10)
        {   
            i++;
            string s = spinner[j];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            if (j >= spinner.Count -1)
            {
                j = 0;
            }
            else
                j++;
            
            
        }

    }
    public void EndMessage()
    {
        Console.WriteLine("Your time is up. Nice work.");

    }

    
        
    
}
    
    // public startMessage - Will hold a message for the user that will display at the begininig of the program
                        // It will welcome the user.
    // public endMessage - Will display a message at the end of the activity.

    // Public countdownTimer - will hold a paused timeout for the activity.

    // public string activity - This will hold the menu for the user to select which activity they would like to do.

