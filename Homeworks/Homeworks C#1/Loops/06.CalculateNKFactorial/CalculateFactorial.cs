//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.


using System;
using System.Numerics;

class CalculateFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger fac1 = 1;
        BigInteger fac2 = 1;
        for (int i = n; i >= 1; i--)
        {


            fac1 *= i;
            fac2 *= k;
            if (k==1)
            {
                continue;
            }
            k--;
        }

        Console.WriteLine(fac1/fac2);
     





    }
}

