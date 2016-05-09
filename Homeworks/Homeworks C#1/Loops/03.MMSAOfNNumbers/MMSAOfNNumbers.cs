//Problem 3. MMSA (Min, Max, Sum, Average) of N Numbers
//Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of
//all numbers (displayed with 2 digits after the decimal point).

//The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
//The output is like in the examples below.




using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
      
        double min = -10000;
        double max = 10000;
      
        for (int i = 0; i < n; i++)
      
        {
            
              double a = double.Parse(Console.ReadLine());
              
              sum += a;
          

              if (max>a)
              {
                  max = a;
                  
              }
            
              if (a>min)
              {
                  min = a;
                  
              }
        }
        
        Console.WriteLine("min={0:F2}",max);
        Console.WriteLine("max={0:F2}", min);
        Console.WriteLine("sum={0:F2}",sum);
        Console.WriteLine("avg={0:F2}",sum / n);
    }
}
