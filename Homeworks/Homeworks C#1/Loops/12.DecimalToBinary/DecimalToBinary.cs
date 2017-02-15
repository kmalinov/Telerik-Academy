using System;
class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(a,2));
        }
    }