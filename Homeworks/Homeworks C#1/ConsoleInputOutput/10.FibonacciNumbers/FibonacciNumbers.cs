//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….


using System;
class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstnumber = -1, secondnumber = 1, thirdnumber = 0;
           
            for (int i = 0; i < n; i++)
           
            {
                thirdnumber = firstnumber + secondnumber;
                
                
                    Console.Write("{0},", thirdnumber);
                
                firstnumber = secondnumber;
                secondnumber = thirdnumber;
            }
            
        }
    
    }

