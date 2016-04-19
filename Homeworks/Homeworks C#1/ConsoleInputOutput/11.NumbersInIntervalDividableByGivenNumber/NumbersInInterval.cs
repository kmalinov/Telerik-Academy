//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder 
//of the division by 5 is 0.


using System;
class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Please Enter Two Positive Numbers");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = firstNumber; i < secondNumber; i++)

        {
            
            if (i % 5 == 0)
            {
                Console.WriteLine(i);
                count++;
                
            }
        }
       
        Console.WriteLine("P = {0}",count);
    }
}
