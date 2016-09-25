//Problem 2.
//Write a program that reads two integer arrays of size N from the console and compares them element by element
//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given


using System;
using System.Linq;



class CompareArrays
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        bool isEqual = true;
        int[] arrA = new int[N];
        int[] arrB = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrA[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < N; i++)
        {
            arrB[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            if (arrA[i]!=arrB[i])
            {
                isEqual = false;
            }

        }
        if (isEqual == true)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }

        /* added second solution
          int n = int.Parse(Console.ReadLine());
        int[] first = new int[n];
        int[] second = new int[n];

        for (int i = 0; i < n; i++)
        {
            first[i] = int.Parse(Console.ReadLine());
            
           
        }
        for (int i = 0; i < n; i++)
        {
            second[i] = int.Parse(Console.ReadLine());
        }
      

        bool isEqual = Enumerable.SequenceEqual(first, second);
        if (isEqual == true)
        {
            Console.WriteLine("Equal");

        }
        else
        {
            Console.WriteLine("Not equal");
        }
         
         
         
         */
    }
}