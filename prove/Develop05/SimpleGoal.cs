using System;
public class SimpleGoal : Goals
{
    

    //Name - Name the goal.
    public string getName()
    {
        string name = Name();
        return name;
    }
    //Describe - Tell what the goal is.
    public string getDescribeGoal()
    {
        string desciption = describeGoal();
        return desciption;
                
    }


    //Points - How many points is the goal worth.
    public int getPoint()
    {
        int point = Point();
        return point;
    }

    // -----------------
    //Record - record event completed. Add points to point total.
    public override void Record()
    {
        Console.WriteLine("You have completed your goal.");
        
        
    }
}