//08 Catalan Numbers

//Description

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula


//Write a program to calculate the Nth Catalan number by given N


using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger c = 1;
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <=N*2; i++)
        {
            a*=(ulong)i;

        }
        for (int i = 1; i <= N+1; i++)
        {
            b *= (ulong)i;
        }
        for (int i = 1; i <= N; i++)
        {
            c *= (ulong)i;
        }

        Console.WriteLine((a)/(b*c));
    }
}