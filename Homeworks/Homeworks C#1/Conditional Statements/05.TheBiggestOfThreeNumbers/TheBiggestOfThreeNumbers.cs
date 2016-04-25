//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;
class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        double aNumber = double.Parse(Console.ReadLine());
        double bNumber = double.Parse(Console.ReadLine());
        double cNumber = double.Parse(Console.ReadLine());

        double biggerNumber = aNumber;
        if (bNumber>aNumber && bNumber>cNumber)
        {
            biggerNumber = bNumber;
        }
        else if (cNumber>aNumber && cNumber>bNumber)
        {
            biggerNumber = cNumber;
        }
        Console.WriteLine(biggerNumber);
    }
}