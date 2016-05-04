//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

using System;
class PointInACircle
{
    static void Main()
    {
        
        double radius = 2.0;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInside = (x*x) + (y*y)<= (radius*radius);
        double distance = Math.Sqrt((x * x) + (y * y));
        
        if (isInside==true)
        {
            Console.WriteLine("yes {0:0.00}",distance);
        }
        else
        {
            Console.WriteLine("no {0:0.00}", distance);
        }
    }
}