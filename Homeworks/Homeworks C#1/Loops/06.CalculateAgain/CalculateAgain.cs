//Problem 6.Calculate Again
//Write a program that calculates N! / K! for given N and K.
//Use only one loop.





using System;
using System.Numerics;
class CalculateAgain
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
     
             BigInteger factorielN = 1;
             BigInteger factorielK = 1;
             for (int i = 1; i <= N; )
             {
                 factorielN *= N;
                 N--;
                 if (i<=K)
                 {
                     
                 
                 factorielK *= K;
                 K--;
                 continue;
             }
                 else
                 {
                     continue;
                 }
             }
             Console.WriteLine(factorielN/factorielK);
            
          
        }
    }
