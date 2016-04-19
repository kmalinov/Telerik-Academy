
//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.



using System;
class SumOfNNumbers
{
    static void Main()
    {
        
        
        int n = int.Parse(Console.ReadLine());
        int sum=0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            
        }
        Console.WriteLine(sum);
       
   
    }
}
