using System;

class Program
{
    static void Main(string[] args)
    {
        Receptions reception = new Receptions("Reception", "require people to RSVP, or register, beforehand.",
                                                "Wedding", "Nov 8, 2023","123 ABC Road","4:30 PM",
                                                "Come and join us for the wedding of Mr and Mis", 
                                                "tmie" , "Huntsman Center", "Oct 25, 2023", "Oct 25, 2023" );

        Outdoor outdoor = new Outdoor("Outdoor", "do not have a limit on attendees, but need to track the weather forecast.",
                                        "Summer Party", "Aug 3, 2023", "12 FunStreet Cir", "5:30 PM",
                                        "Come and Join the fun at our summar bbq party, hotdogs and Hambergers, chips", 
                                        "The big red house.");
        
        Lectures lecture = new Lectures("Lecture", "have a speaker and have a limited capacity.",
                                            "Advanced Programming", "Decimal 4,2023", "1251 South Main St", "7:30 PM", 
                                            "Come and hear all of the latest updates on the most andvanced progams", 
                                            "Dr Somebody");
        
        Console.Clear();
        int i = 0;
        while(i <=3)
        {
            //Menu
            Console.WriteLine("Which type of vent would you like to look at.");
            Console.WriteLine("\n1. Lecture\n2. Reception\n3. Outdoor\n4. Exit\n");
            string s1 = Console.ReadLine();
            int o1 = int.Parse(s1);
            
            Console.WriteLine("How much detail about the Event would you like to see:\n ");
            Console.WriteLine("Standard details - Lists the title, description, date, time, and address.\n");
            Console.WriteLine("Full Details - Lists all of the above, plus type of event and information specific"); 
            Console.WriteLine("               to that event type. For lectures, this includes the speaker name and capacity.");
            Console.WriteLine("               For receptions this includes an email for RSVP. For outdoor gatherings, ");
            Console.WriteLine("               this includes a statement of the weather.\n");
            Console.WriteLine("Short description - Lists the type of event, title and the date.\n");
            Console.WriteLine("1. Standard info:\n2. Full Details:\n3. Short Description:\n");
            string s2 = Console.ReadLine();
            int o2 = int.Parse(s2);
            
            if (o1 == 1)
            {   
                
                if(o2 == 1)
                {
                    lecture.SetStandardDetail();
                }
                else if(o2 == 2)
                {
                    lecture.DisplayFullDetail();
                }
                else if(o2 == 3)
                {
                    lecture.DisplayShortDetail();
                }
                else
                {
                    Console.WriteLine($"{o2} is not an option try again");
                }
            }

            else if (o1 == 2)
            {
                 if(o2 == 1)
                {
                    reception.SetStandardDetail();
                }
                else if(o2 == 2)
                {
                    reception.DisplayFullDetail();
                }
                else if(o2 == 3)
                {
                    reception.DisplayShortDetail();
                }
                else
                {
                    Console.WriteLine($"{o2} is not an option try again");
                }
            }

            else if(o1 == 3)
            {
                 if(o2 == 1)
                {
                    outdoor.SetStandardDetail();
                }
                else if(o2 == 2)
                {
                    outdoor.DisplayFullDetail();
                }
                else if(o2 == 3)
                {
                    outdoor.DisplayShortDetail();
                }
                else
                {
                    Console.WriteLine($"{o2} is not an option try again");
                }
            }
            else
            {
                Console.WriteLine($"{o1} is not an option try again");
            }
            
        }
        

    }
}