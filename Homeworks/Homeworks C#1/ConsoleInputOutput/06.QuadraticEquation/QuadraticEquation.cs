//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).


using System;
class QuadraticEquation
{
    static void Main()
    {

        Console.WriteLine("Please Enter values for A, B and C");

        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double diskriminant = Math.Pow(B, 2) - (4 * A * C);
        double squareDiskriminant = Math.Sqrt(diskriminant);
        double x1;
        double x2;
        double x12;

        Console.WriteLine("The diskriminant of quadratic equation is: " + diskriminant);

        if (diskriminant<0)
        {
            Console.WriteLine("The quadratic equation nas no real roots!!!");
        }
        else if (diskriminant==0)
        {
            x12 = -B/(2*A);
            Console.WriteLine("The quadratic equation nas one real root x12: {0:0.00}", x12);
        }
        else if (diskriminant>0)
        {
            x1 = (-B + squareDiskriminant) / (2 * A);
            x2 = (-B - squareDiskriminant) / (2 * A);
            Console.WriteLine("The quadratic equation has two real roots x1={0:0.00} and x2={1:0.00}", x1,x2);


        }


       


    }
}