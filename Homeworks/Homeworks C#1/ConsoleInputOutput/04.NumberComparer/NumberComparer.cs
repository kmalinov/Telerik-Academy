//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.




using System;
class NumberComparer
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
           double biggerNumber = (Math.Max(firstNumber,secondNumber));
            Console.WriteLine("The bigger number is: {0}",biggerNumber);
        }
    }