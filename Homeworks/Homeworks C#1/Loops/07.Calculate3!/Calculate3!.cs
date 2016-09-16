//Calculate 3!

//Description

//In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of 
//combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard 
//deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.



using System;
using System.Numerics;
class Program

{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger aFac = 1;
        BigInteger bFac = 1;
        BigInteger sumFac = 1;

        for (int i = 1; i <= N; i++)
        {
            aFac *= i;
        }

        for (int i = 1; i <= K; i++)
        {
            bFac *= i;
        }
        for (int i = N - K; i >= 1; i--)
        {
            sumFac *= i;
        }
        Console.WriteLine(aFac/(bFac*sumFac));
     

    }
}
