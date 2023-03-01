using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> sh = new List<Shape>();

        Square sq = new Square("Blue", 4);
        sh.Add(sq);

        Recatangle re = new Recatangle("Yellow", 3, 4);
        sh.Add(re);

        Circle ci = new Circle("Purple", 4);
        sh.Add(ci);

        foreach (Shape s in sh)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of: {area}");


        }
        


    }
}