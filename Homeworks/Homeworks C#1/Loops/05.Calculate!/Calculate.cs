//Problem 5. Calculate!
//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Numerics;
class Calculate
{
    static void Main(string[] args)
    {
      
        int N = int.Parse(Console.ReadLine());
        double X = double.Parse(Console.ReadLine());
        
          ulong factorial = 1;
        double sum =0;
        double divider =1;
       
        for (int i = 1; i <= N; i++)
        {
            
            factorial *= (ulong)i;
            divider = Math.Pow(X,i);

            sum += factorial/divider;
         
        }

        
      
        Console.WriteLine("{0:F5}", 1+ sum);
    }
}