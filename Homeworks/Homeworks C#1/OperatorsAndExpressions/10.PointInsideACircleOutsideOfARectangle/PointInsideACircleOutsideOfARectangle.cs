//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle 
//R(top=1, left=-1, width=6, height=2).


using System;
class PointInsideACircleOutsideOfARectangle
{
    static void Main ()
    {
        double radius = 1.5;
        double centerK = 1;

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInside = (Math.Pow((x-centerK), 2) + Math.Pow((y-centerK), 2) <= Math.Pow(radius, 2)); // pithagoras theorem
       // Console.WriteLine(isInside);
        bool insideRectangle = (x > -1 && x < 5) && (y < 1 && y > -1);
        bool a = isInside && !insideRectangle;
        Console.WriteLine(a);
        
        //{
        //    Console.WriteLine("the Point is in the circle and outside the rectangle");   
        //}



    }
}
