//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.



using System;
class MultiplicationSign
{
    static void Main()
    {
        double firstnumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstnumber+secondNumber+thirdNumber > 0)
        {
            Console.WriteLine("+");
        }
        else if (firstnumber+secondNumber+thirdNumber < 0)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}
