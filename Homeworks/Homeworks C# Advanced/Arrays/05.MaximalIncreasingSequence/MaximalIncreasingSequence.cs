// Problem 05.
//Description

//Write a program that finds the length of the maximal increasing sequence in an array of N integers.


using System;
using System.Collections.Generic;

class MaxSequenceInArray
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 3, 2, 2, 2 };

        int bestSequence = 1;
        int currentSequence = 1;
        int bestNumber = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentSequence++;
            }
            else
            {
                currentSequence = 1;
            }
            if (currentSequence >= bestSequence)
            {
                bestSequence = currentSequence;
                bestNumber = array[i];
            }
        }

        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write("{0} ", bestNumber);
        }
    }
}