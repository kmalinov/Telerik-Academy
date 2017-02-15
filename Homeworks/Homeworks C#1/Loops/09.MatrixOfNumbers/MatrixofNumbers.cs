// 10.Matrix of Numbers

//Description

//Write a program that reads from the console a positive integer number N and prints a matrix like in the examples below. Use two nested loops.

//Challenge: achieve the same effect without nested loops
using System;
class MatrixOfNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        for (int row = 1; row <= N; row++)
        {
            Console.WriteLine();
            


            for (int cow = row; cow <= N+row-1; cow++)
            {
                
                
                Console.Write(cow+" ");
            }
        
        }
    }
}