//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).
//Input

//On the first line you will receive the first char array as a string
//On the second line you will receive the second char array as a string
//Output

//Print < if the first array is lexicographically smaller
//Print > if the second array is lexicographically smaller
//Print = if the arrays are equal



using System;
using System.Linq;
using System.Collections.Generic;
class CompareCharArrays
{
    static void Main()
    {

        string arr1 = Console.ReadLine();
        string arr2 = Console.ReadLine();

     
        char[] firstA = arr1.ToCharArray();
        char[] secondA = arr2.ToCharArray();

        if (string.Join(" ", arr1) == string.Join(" ", arr2))
        {
            Console.Write("=");
            
        }


        else if (string.Join("", arr1) != string.Join("", arr2) && firstA.Length > secondA.Length)
        {
            Console.Write(">");
        }

        else if (string.Join("", arr1) != string.Join("", arr2) && firstA.Length < secondA.Length)
        {
            Console.Write("<");
        }

  

    }
}