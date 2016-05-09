﻿//Problem 2.
//Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7,
//on a single line, separated by a space.





using System;
class NotDivisibleNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i%7 == 0 || i%3 == 0)
            {
                continue;
            }
           
            Console.Write("{0} ",i);
        }
    }
}