//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;
class Trapezoids
{
    static void Main()
    {
        

         double aSide = double.Parse(Console.ReadLine());
         double bSide = double.Parse(Console.ReadLine());
         double hSide = double.Parse(Console.ReadLine());
        
        
        
        double sTrapezoid = ((aSide + bSide)*hSide)/2;

        Console.WriteLine("{0:0.0000000}",sTrapezoid);
    }
}