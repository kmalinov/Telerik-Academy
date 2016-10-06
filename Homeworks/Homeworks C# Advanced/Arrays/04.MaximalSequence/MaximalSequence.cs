//Problem 04. Maximal sequence
//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given




using System;
class MaximalSequence
{
    static void Main()
    {

        int counter = 0;
        int maxConter = 0;

        int A = int.Parse(Console.ReadLine());

        int[] arr = new int[A];
        int b = 0;
        int c = 0;
        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(Console.ReadLine());
            c = arr[i];
            if (arr[i] == b)
            {
                counter++;
                if (maxConter<=counter)
                {
                    maxConter = counter;
                }
            }
            else
            {
                counter = 0;
            }
            b = c;
        }

        if (arr[0] == 0)
        {
            Console.WriteLine(maxConter);
        }

        else
        {
            Console.WriteLine(maxConter + 1);
        }
    }
}