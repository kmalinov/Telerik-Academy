//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)

using System;
class PointInACircle
{
    static void Main()
    {
        
        double radius = 2;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInside = (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius, 2)); // pithagoras theorem
        Console.WriteLine(isInside);
      //  double isInside = Math.Pow(x, 2) + Math.Pow(y, 2);
      //  isInside <= Math.Pow(radius,2);
        //if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(radius,2))
        //{
        //    Console.WriteLine("Is Inside The Circle");
        //}

        //else
        //{
        //    Console.WriteLine("Is Not Inside");
        //}
    }
}