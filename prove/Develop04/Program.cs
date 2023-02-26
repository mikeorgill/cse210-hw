using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        BaseActivity baseA = new BaseActivity();
        ListingActivity listingA = new ListingActivity();
        ReflictionActivity reflect = new ReflictionActivity();
        
        //Call the time for timer countdown.
        DateTime startTime = DateTime.Now;
        DateTime endTime;
        
        //Creat the user input and selection.
        string userInput = " ";
        int selection = 0;
        int a = 0;
        while(a != 4)
        {
            
            
            //baseA.CountdownTimer();
            //baseA.SpinningTimer();
           
            //Create Menu.
            Console.WriteLine("What activity would you like to do:");
            Console.WriteLine("1 - Breathing Activity.");
            Console.WriteLine("2 - Refliction Activity.");
            Console.WriteLine("3 - Listing Activity.");
            Console.WriteLine("4 - Quit.");

            //Assign user selection.
            userInput = Console.ReadLine();
            selection = int.Parse(userInput);
            
            // Check to see if user entered a number 5 and above. Then select which option was picked.
            if(selection >= 5)
            {
                Console.WriteLine("Not a valid option: Select 1 thru 4");
                userInput = Console.ReadLine();
                selection = int.Parse(userInput);
            }
            else if(selection == 1){

                BreathingActivity breath = new BreathingActivity();
                Console.Clear();
                breath.StartMessage();
                Console.WriteLine();
                int timer = baseA.Timer();
                baseA.CountdownTimer();
                startTime = DateTime.Now;
                endTime = startTime.AddSeconds(timer);
                
                while(DateTime.Now < endTime)
                {
                    
                    breath.BreathIn();
                    //Console.Clear();
                    breath.BreathOut();
                    //Console.Clear();
                }
                baseA.EndMessage();
            }
            else if(selection ==2){
                
                Console.Clear();
                reflect.refStartMessage();
                Console.WriteLine();
    
                reflect.promptQuestion();
                reflect.EndMessage();          
    
            }
            else if(selection == 3){
                
                Console.Clear();
                listingA.listMessage();
                Console.WriteLine();
                listingA.listingPrompt();

            }
            else                      
                a = 4;
            
                
            
           
        }
        Console.WriteLine("You have ended the program have a good day.");
        //Console.WriteLine($"User Input: {userInput}");
        //Console.WriteLine($"Selection: {selection}");
    }
}