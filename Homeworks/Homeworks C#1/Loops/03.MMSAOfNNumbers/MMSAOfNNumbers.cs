//MMSA (Min, Max, Sum, Average) of N Numbers

//Description

//Write a program that reads from the console a sequence of N real numbers and returns the minimal, the maximal number, the sum and the 
//average of all numbers (displayed with 2 digits after the decimal point).

//The input starts by the number N (alone in a line) followed by N lines, each holding an real number.
//The output is like in the examples below.


using System;
class MMSAOfNNumbers
{
    static void Main()
    {
        MMSA(int.Parse(Console.ReadLine()));


    }
    static void MMSA(int N)
    {
        double j = 0;
        double sum = 0;
        double min = int.MaxValue;
        double max = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            j = int.Parse(Console.ReadLine());
            sum += j;
            if (j > max)
            {
                max = j;

            }
            if (j < min)
            {
                min = j;

            }

        }

        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", sum);
        Console.WriteLine("avg={0:0.00}", sum / N);
    }
}