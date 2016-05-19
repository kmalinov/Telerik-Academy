//Problem 01.
//Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained 
//array on the console.



using System;
class Program
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int[] multipleNumbers = new int[n];

        for (int i = 0; i <n; i++)
        {
            
            
            Console.WriteLine(string.Join("",i*5));
        }
    }
}
