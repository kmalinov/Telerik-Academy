//Binary to Decimal

//Description
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.



using System;
class BinaryToDecimal
{
    static void Main()
    {
        string binary = Console.ReadLine();
        int sum = 0;

        foreach (char bit in binary)
        {
            sum = (bit - '0') + sum * 2;
        }

            
        Console.WriteLine(sum);
    }
}
