public class Activity
{
    //minutes, distance, speed, pace, getSummary
    int _minutes;
    double _distance;
    double _speed;
    double _pace;

    public Activity(int minutes)
    {
        _minutes = minutes;
    }
    public string Date()
    {
        DateTime date = DateTime.Today;
        string dateOutput = date.ToString("MMM dd, yyyy");
        //Console.WriteLine(dateOutput);
        //Console.WriteLine(date);
        return dateOutput;
    }
    public virtual int Minutes()
    {
        return _minutes;
    }
    //Distance
    public virtual double Distance()
    {
        return _distance;
    }
    //Speed
    public virtual double Speed()
    {
        _speed = (_distance/_minutes) * 60;
        return _speed;
    }
    //Pace
    public virtual double Pace()
    {
        return _pace;
    }
    //GetSummary
    public virtual void GetSummary()
    {

    }
}