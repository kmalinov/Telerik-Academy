//02.Not Divisible Numbers

//Description

//Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single
//line, separated by a space.

using System;
class NotDivisibleNumberswewer
{
    static void Main()
    {
        NotDivisibleNumbers(int.Parse(Console.ReadLine()));

    }

    static void NotDivisibleNumbers(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            if (i%3 == 0 || i%7 == 0)
            {
                continue;
            }
            else
            {
                Console.Write(i + " ");
            }
            
        }
    }


}
