
class ReflictionActivity : BreathingActivity
{
    //Random Prompt after starting message
    private string prompt1 = ("Think of a time when you stood up for someone else.");
    private string prompt2 = ("Think of a time when you did something really difficult.");
    private string prompt3 = ("Think of a time when you helped someone in need.");
    private string prompt4 = ("Think of a time when you did something truly selfless.");

        //Questions after prompt.
    List<string> question = new List<string>{"Why was this experience meaningful to you?", 
                                            "Have you ever done anything like this before?",
                                            "How did you get started?", 
                                            "How did you feel when it was complete?",
                                            "What made this time different than other times when you were not as successful?",
                                            "What is your favorite thing about this experience?",
                                            "What could you learn from this experience that applies to other situations?",
                                            "What did you learn about yourself through this experience?",
                                            "How can you keep this experience in mind in the future?"};

    
    public void refStartMessage()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
        Thread.Sleep(5000);
    }

    public void prompt()
    {
        Random rand = new Random();
        int randPrompts = rand.Next(1,4);

        if (randPrompts == 1)
        {
            Console.WriteLine(prompt1);
        }
        else if (randPrompts == 2)
        {
            Console.WriteLine(prompt2);
        }
        else if (randPrompts == 3)
        {
            Console.WriteLine(prompt3);
        }
        else
            Console.WriteLine(prompt4);
        CountdownTimer();

    }
    
    public void promptQuestion()
    {   
        
        BaseActivity baseA = new BaseActivity();
        int timer = baseA.Timer();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);
        
        while(DateTime.Now < endTime)
        {
            prompt();
            for(int i = 0; i < question.Count; i++)
            {   
                Console.WriteLine(question[i]);
                Thread.Sleep(5000);
                if(i > question.Count){
                    i = 0;
                }
                else if(DateTime.Now > endTime)
                {
                    i = question.Count + 1;
                }

            }
        }
    }



//After question pause for 5 seconds.

//Continue displaying question until user time has run out.
}