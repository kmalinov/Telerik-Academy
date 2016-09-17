//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.




using System;
using System.Numerics;
class Calculate
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());
        

        ulong aFac = 1;
        double sum = 1.0;
        

        for (int i = 1; i <= N; i++)
        {
            aFac *= (ulong)i;
            sum += aFac / Math.Pow(X,i);

            
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
