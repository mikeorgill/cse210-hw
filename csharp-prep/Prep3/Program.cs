using System;

class Program
{
    static void Main(string[] args)
    {
        string game = "";
        do
        {
            /*Console.Write("What is the magic number? ");
            string rand_input = Console.ReadLine();
            int rand_num = int.Parse(rand_input);*/

            Random randomGenerator = new Random();
            int rand_num = randomGenerator.Next(1,100);

            Console.WriteLine($"Magic number is: {rand_num}");

            int guess = 0;

            while (guess != rand_num)
            {
                Console.Write("What is your guess? ");
                string input_guess = Console.ReadLine();
                guess = int.Parse(input_guess);
           

                if (guess > rand_num)
                {
                    Console.WriteLine($"To High: {guess}");
                }
                else if(guess < rand_num)
                {
                    Console.WriteLine($"To Low: {guess}");
                }
                else if(guess == rand_num)
                {
                    Console.WriteLine($"You guessed it!: {guess}");
                }
            }
            //Console.WriteLine($"You guessed it!: {guess}");

            Console.WriteLine("Do you want to play again? (yes or no)");
            game = Console.ReadLine();

        }while(game != "no");
        Console.WriteLine("Have a good day!");
    }
}