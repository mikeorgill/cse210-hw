using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Hello Foundation4 World!\n");
        // Running takes time in minutes and distance ran.
        Running run = new Running(60, 5);
        
        // Swimmming take time in minutes and lap count.
        Swimming swim = new Swimming(90, 50);

        // Bicycle take the time in minutes and the speed in mph.
        Bicycles bike = new Bicycles(95, 15);
        
        bike.Distance();
        bike.BikePace();
        bike.GetSummary();
        
        //swim.Date();
        swim.Distance();
        swim.SwimPace();
        swim.GetSummary();

        run.Distance();
        run.RunPace();
        run.GetSummary();


        

        
        
    }
}