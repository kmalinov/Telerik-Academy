//Problem.11 GCD

//Description

//Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.

//Use the Euclidean algorithm (find it in Internet).




using System;
using System.Linq;
class Program
{
    static void Main()
    {
     
        string hi = Console.ReadLine();

        int a;
        int b;
        string[] splitTry = hi.Split();
        a = int.Parse(splitTry[0]);
        b = int.Parse(splitTry[1]);
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


