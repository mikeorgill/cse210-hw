public class Running : Activity
{
    //Track - Distance.
    
     private int _minutes;
    private double _speed;
    private double _distance;
    private double _pace;
    //Distance
    public Running(int minutes, double distance) : base(minutes)
    {
        _minutes = minutes;
        _distance = distance;
    }
    public override double Distance()
    {
        return _distance;
    }
    //Speed
    public override double Speed()
    {
        return _speed = Math.Round(_distance / _minutes, 2) * 60;
    }
    //Pace
    public double RunPace()
    {
        return _pace = Math.Round(_minutes / _distance, 1);
    }

    //GetSummary
    public override void GetSummary()
    {
        Console.WriteLine($"{Date()} Running ({_minutes} min): Distance {_distance} miles, Speed {Speed()} mph, Pace: {RunPace()} min per mile");
    }
}