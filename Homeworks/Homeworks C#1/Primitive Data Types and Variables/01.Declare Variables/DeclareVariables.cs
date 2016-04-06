//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.


using System;
class DeclareVariables
{
    static void Main()
    {
        sbyte a =-115;
        short b =-1000;
        byte c = 97;
        int d = 52130;
        long e = 4825932;
        Console.WriteLine("The valiues of numbers are\n{0}\n{1}\n{2}\n{3}\n{4}", a, b, c, d, e);

    }
}
