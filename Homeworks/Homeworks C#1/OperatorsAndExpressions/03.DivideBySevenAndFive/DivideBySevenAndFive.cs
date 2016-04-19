//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.



using System;
class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pleaase Enter An Integer to Check");
        int integer = int.Parse(Console.ReadLine());
        bool devideBySevenAndFive = (integer % 7 == 0) && (integer % 5 == 0);

        Console.WriteLine(devideBySevenAndFive);


        Console.WriteLine(@"{0} Is devisible by 7 and 5 ------> {1}", integer, devideBySevenAndFive);
        
       
    }
}
