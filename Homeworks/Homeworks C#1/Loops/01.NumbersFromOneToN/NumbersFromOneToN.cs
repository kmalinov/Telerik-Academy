//01.Description

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to N inclusive, on a single line, separated by a whitespace.

//Input

//The input will consist of a single line - the number N
//Output

//The output should consist of a single line - the numbers from 1 to N, separated by a whitespace
//Constraints

//N will be a valid positive 32-bit integers
//Time limit: 0.1s
//Memory limit: 16MB

using System;
class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.Write(i + " ");
            Console.WriteLine("hi");
        }
    }
}
