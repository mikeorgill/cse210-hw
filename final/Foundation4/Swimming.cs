public class Swimming : Activity
{
    //Track - Laps
    
    private int _laps;
    private int _minutes;
    private double _speed;
    private double _distance;
    private double _pace;
    
    public Swimming (int minutes, int laps) : base(minutes)
    {
        _laps = laps;
        _minutes = minutes;
    }
    //Distance
    public override double Distance()
    {  
        //Distance for swimming is lap * (50 / 1000 *.62) =.031 
        _distance = _laps * .031;
        //Console.WriteLine($"Distance: {_distance}");
        return _distance;
        
    }
    //Speed
    public override double Speed()
    {   
        _speed = Math.Round((_distance / _minutes) * 60, 2);
        //Console.WriteLine($"Speed: {_speed}");
        return _speed;
    }
    //Pace
    public double SwimPace()
    {   
        _pace = Math.Round(_minutes / _distance, 1);
        //Console.WriteLine($"Pace: {_pace}");
        return _pace;
    }
    //GetSummary
    public override void GetSummary()
    {   
        Console.WriteLine($"{Date()} Swimming ({_minutes} min): Distance {_distance} miles, Speed {Speed()} mph, Pace: {SwimPace()} min per mile");
    }
}