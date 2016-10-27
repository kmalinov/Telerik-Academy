//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.




using System;
class OddOrEvenIntegers
{
    static void Main()
    {
       // Console.WriteLine("Please Enter an Integer to Chek - Even or Odd");
        int integer = int.Parse(Console.ReadLine());
        if (integer % 2 == 0)
        {
            Console.WriteLine("even {0}",integer);
        }


        else
        {
            Console.WriteLine("odd {0}", integer);
        }


    }
}