using System;

public class Fraction{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        //Constructor 1/1
        _top = 1;
        _bottom = 1;

    }

    public Fraction(int topNumber){
         
         //Consturctor for top number.
        _top = topNumber;
        _bottom = 1;

    }

    public Fraction(int top, int bottom){

        //Consturctor for both top and bottom.
        _top = top;
        _bottom = bottom;

    }

    public string GetFractionString(){
        
        //Return as a fraction in string form.
        string number = $"{_top}/{_bottom}";
        return number;
    }

    public double GetDecimalValue(){
        
        //Return a double by dividing the top form the bottom.
        return (double)_top / (double)_bottom;
    }
}