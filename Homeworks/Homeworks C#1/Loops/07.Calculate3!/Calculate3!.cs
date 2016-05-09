//Problem 7. Calculate 3!
//In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations)
//is calculated by the following formula:N! / (K! * (N - K)!) formula For example, there are 2598960 ways to withdraw 5 cards out of a standard 
//deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.






using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger minusFactorial = 1; 
        for (int i = 1; i <= N; i++)
        {
            nFactorial *= i;
        }
        
        for (int i = 1; i <= K; i++)
        {
            kFactorial *= i;
        }
        for (int i = 1; i <=N-K; i++)
        {
            minusFactorial *= i;
           
        }
        Console.WriteLine(nFactorial/(kFactorial*minusFactorial));
       
    }
}
