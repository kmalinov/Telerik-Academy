using System;
class DecimalToHex
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(a, 16).ToUpper());
    }
}
