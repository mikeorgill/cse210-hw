using System;

public class EnternalGoal : Goals
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
            
        string userDescribedGoal = describeGoal();
        return userDescribedGoal;
    }


    //Points - How many points is the goal worth.
    public int getPoint()
    {
        int point = Point();
        return point;
    }
    //-------------------
    //Record - Give points each time the goal is meet. This goal will never be completed. Add points to point Total.
           
}