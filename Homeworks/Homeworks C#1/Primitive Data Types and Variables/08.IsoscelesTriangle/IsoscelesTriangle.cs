//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:



using System;
class IsoscelesTriangle
{
    static void Main()
    {
        
        string copyRigrh = "\u00A9";

        //Console.WriteLine("           {0}",copyRigrh);
        //Console.WriteLine("          {0} {1}",copyRigrh, copyRigrh);
        //Console.WriteLine("         {0} K {1}", copyRigrh, copyRigrh);
        //Console.WriteLine("        {0} {1} {2} {3}", copyRigrh, copyRigrh, copyRigrh, copyRigrh);
        //Console.WriteLine();



        Console.WriteLine("           {0}", copyRigrh);
        Console.WriteLine();
        Console.WriteLine("          {0} {1}", copyRigrh, copyRigrh);
        Console.WriteLine();
        Console.WriteLine("         {0} K {1}", copyRigrh, copyRigrh);
        Console.WriteLine();
        Console.WriteLine("        {0} {1} {2} {3}", copyRigrh, copyRigrh, copyRigrh, copyRigrh);
        Console.WriteLine();
     
    }
}