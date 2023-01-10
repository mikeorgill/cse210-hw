using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int i = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while(i != 0)
        {
            
            Console.Write("Enter number: ");
            string input_num = Console.ReadLine();
            int num = int.Parse(input_num);
            i = num;
            if (num != 0)
            {
                 numbers.Add(num);
            }
           
            //Console.WriteLine($"i = {num}");
        }    
        int sum = 0;
        float average = 0;
        int max = 0;
        foreach (int number in numbers)
        {
            if (number != 0)
            {
                //Console.Write($"[{number}] ");
                sum = number + sum;
                average = ((float)sum) / numbers.Count;
            }
            
            if (number > max)
            {
                max = number;
            }
            
        }
        //Console.WriteLine("\nNumbers: {0} ", numbers.Count);
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
            

        
        

    }
}