//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average 
//of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double a = 0;
        double min = int.MaxValue;
        double max = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a > max)
            {
                max = a;
            }

            
            if (a < min)
            {
                min = a;
            }
            sum += a;

        }

        
        Console.WriteLine("min={0:0.00}",min);
        Console.WriteLine("max={0:0.00}",max);
        Console.WriteLine("sum={0:0.00}",sum);
        Console.WriteLine("avg={0:0.00}",sum/n);

    }
}
