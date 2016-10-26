using System;
using System.Linq;
class GetLargestNumber
{
    static void Main()
    {
        int[] j = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int a = j[0];
        int b = j[1];
        int c = j[2];

        
        if (GetMax(a,b)>c)
        {
            Console.WriteLine(GetMax(a,b));
        }

        else
        {
            Console.WriteLine(c);
        }



    }
    static int GetMax(int a, int b)
    {

        return(Math.Max(a,b));
    }

}


