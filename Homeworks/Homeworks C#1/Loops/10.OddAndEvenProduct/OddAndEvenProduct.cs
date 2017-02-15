//10.Odd and Even Product

//Description

//You are given N integers (given in a single line, separated by a space).

//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

using System;
class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        string[] numbers = a.Split(' ');
        int c = 1;
        int d = 1;


        for (int i = 0; i < N; i++)
        {

            if (i % 2 == 0)
            {
                c *= int.Parse(numbers[i]);
            }
            else
            {
                d *= int.Parse(numbers[i]);
            }
        }
        if (c==d)
        {
            Console.WriteLine("yes {0}", c);
        }
        else
        {
            Console.WriteLine("no {0} {1}",c,d);
        }
    }
}
