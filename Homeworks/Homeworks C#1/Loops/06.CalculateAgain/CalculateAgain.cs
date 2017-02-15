// 06.Calculate Again

//Description

//Write a program that calculates N! / K! for given N and K.

//Use only one loop.



using System;
class CalculateAgain
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        double a = 1;
        double b = 1;
        for (int i = 1; i <= N; i++)
        {
            a *= i;

            if (i<=K)
            {
                b *= i;
            }
            else
	        {
                continue;
	        }


            
        }
        Console.WriteLine(a / b);
    }
}