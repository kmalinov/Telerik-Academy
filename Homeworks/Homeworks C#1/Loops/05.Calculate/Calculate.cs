// 05.Calculate!

//Description

//Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

//Use only one loop. Print the result with 5 digits after the decimal point.




using System;
class Calculate
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        int X = int.Parse(Console.ReadLine());

        //double sum = 1;
        //double factorial = 1;
        //for (int i = 1; i <=N; i++)              calculate for : N = 5
        //{                                                        X = 2
        //    factorial *= i;
        //    sum += factorial/Math.Pow(N,X);
        //}
        // Console.WriteLine("{0:0.00000}",sum);

        //int N = int.Parse(Console.ReadLine());
        //int X = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;
        for (int i = 1; i <= N; i++)
        {
            factorial *= i;
            sum += factorial / (Math.Pow(X,i));
        }
        Console.WriteLine("{0:0.00000}", sum);
        
    }
}
