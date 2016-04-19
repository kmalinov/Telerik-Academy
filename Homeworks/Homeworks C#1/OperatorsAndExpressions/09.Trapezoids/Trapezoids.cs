//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Please Enter A,B and H ");

         double aSide = double.Parse(Console.ReadLine());
         double bSide = double.Parse(Console.ReadLine());
         double hSide = double.Parse(Console.ReadLine());
        
        
        
        double sTrapezoid = ((aSide + bSide)*hSide)/2;

        Console.WriteLine("The Area of this trapezoid is: {0}",sTrapezoid);
    }
}