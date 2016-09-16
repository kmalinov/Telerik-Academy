//Problem 9 MatrixOfNumbers

//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.


using System;
class Program
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <=N; i++)
        {
            Console.WriteLine();
           
            for (int j = i; j < N+i; j++)
            {
                Console.Write(j+" ");
               
            }
            
            
            
        }
    }
}
