//Catalan Numbers

//Description

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula

//Write a program to calculate the Nth Catalan number by given N


using System;
using System.Numerics;
class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        
        BigInteger aFac = 1;
        BigInteger bFac= 1;
        BigInteger sumFac= 1;
        for (int i = 1; i <= 2*N; i++)
        {
            bFac *= i;
        }

        for (int i = 1; i <= N; i++)
        {
            aFac *= i;
           
            sumFac *= (i + 1);

        }

       Console.WriteLine(bFac/(sumFac*aFac));
       
        
    }
}