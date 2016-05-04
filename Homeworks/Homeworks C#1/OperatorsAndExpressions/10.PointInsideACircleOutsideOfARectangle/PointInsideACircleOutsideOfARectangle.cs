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
       
        bool insideRectangle = (x >= -1 && x <= 5) && (y <= 1 && y >= -1);
        if (isInside==true&&insideRectangle==true)
        {
            Console.WriteLine("inside circle inside rectangle");
        }
       
        else if(isInside==true && insideRectangle==false)
        {
            Console.WriteLine("inside circle outside rectangle");
        }
       
        else if (isInside==false && insideRectangle==false)
	{
        Console.WriteLine("outside circle outside rectangle");
	}

        else 
        {
            Console.WriteLine("outside circle inside rectangle");
        }
    }
}
