//"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
class ListingActivity : ReflictionActivity
{

    List<string> listingList = new List<string>{"Who are people that you appreciate?",
                                                "What are personal strengths of yours?",
                                                "Who are people that you have helped this week?",
                                                "When have you felt the Holy Ghost this month?",
                                                "Who are some of your personal heroes?"
                                                };
    public void listMessage()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life \nby having you list as many things as you can in a certain area.");
    }
    public void listingPrompt()
    {
        List<string> list = new List<string>();
        
        int timer = Timer();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timer);

        while(DateTime.Now < endTime)
        {   
            
            for(int i = 0; i < listingList.Count; i++)
            {
                Console.WriteLine(listingList[i]);
                string answer = Console.ReadLine();
                list.Add(answer);
                

                if(DateTime.Now > endTime)
                {
                    i = listingList.Count + 1;
                }
                else if(i > listingList.Count)
                {
                    i = 0;
                }
            }
        }
        Console.WriteLine($"You listed {list.Count} items.");                                           
        
    }

}