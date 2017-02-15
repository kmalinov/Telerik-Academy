using System;
using System.Numerics;
class TrailingZeroInN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger a = 1;
        int count = 0;
        for (int i = 1; i <= N; i++)
        
        {
            a *= i;
        }
        string b = a.ToString();
        

        for (int i = b.Length-1; i >=0; i--)
        {
            if (b[i]=='0')
            {
                count++;
            }
            else
            {
                break;
            }
          
        }
        Console.WriteLine(count);
    }
}
