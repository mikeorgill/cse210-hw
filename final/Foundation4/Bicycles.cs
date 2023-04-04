public class Bicycles : Activity
{
    
    private int _minutes;
    private double _speed;
    private double _pace;
    private double _distance;
    public Bicycles (int minutes, double speed) : base(minutes)
    {   
        _minutes = minutes;
        _speed = speed;

    }
    //Distance
    public override double Distance()
    {
        return _distance;
    }
    //Speed
    public override double Speed()
    {   
        // _speed = ( _distance / _minutes ) * 60;
        return _speed;
    }
    //Pace
    public double BikePace()
    {
        _pace = Math.Round(60 / _speed, 2);
        return _pace;
    }
    //GetSummary
    public override void GetSummary()
    {
        Console.WriteLine($"{Date()} Cycling ({_minutes} min): Distance {_distance} miles, Speed {_speed} mph, Pace: {BikePace()} min per mile");
    }
}