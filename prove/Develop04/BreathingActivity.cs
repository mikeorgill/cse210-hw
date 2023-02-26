//"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."

//display Breath-IN and Breath-OUT with a countdown timer.

//continue until user timer has ended.

class BreathingActivity : BaseActivity
{
    public void StartMessage()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly.\nClear your mind and focus on your breathing.");
        SpinningTimer();
    }
    public void BreathIn()
    {
        
        Console.Write($"Breath In: ");
        CountdownTimer();
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b           \b\b\b\b\b\b\b\b\b\b\b");
    }

    public void BreathOut()
    {
        Console.Write("Breath Out: ");
        CountdownTimer();
        Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b            \b\b\b\b\b\b\b\b\b\b\b\b");
        
    }

    
}