//15.GCD

//Description

//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.

//Use the Euclidean algorithm (find it in Internet).

using System;
class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] array = input.Split();

        int a = int.Parse(array[0]);
        int b = int.Parse(array[1]);
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            Console.WriteLine(b);
        else
            Console.WriteLine(a);
    }
}