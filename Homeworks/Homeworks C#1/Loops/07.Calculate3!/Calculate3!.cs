// 07 Calculate 3!

//Description

//In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations) 
//is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is 
//to write a program that calculates N! / (K! * (N - K)!) for given N and K.

//Try to use only two loops.


using System;
class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int nFactorial = 1;
            int kFactorial = 1;
            int bFactorial = 1;
       
            for (int i = 1; i <= N; i++)
            {
                nFactorial *= i;
                if (i<=K)
                {
                    kFactorial *= i;
                }
                else
                {
                    continue;
                }
            }
            for (int i = 1; i <= N-K; i++)
            {
                bFactorial *= i;
            }
            Console.WriteLine(nFactorial/(kFactorial*bFactorial));
        }
}













