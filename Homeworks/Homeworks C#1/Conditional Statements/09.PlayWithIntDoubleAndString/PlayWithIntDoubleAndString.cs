//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.


using System;
class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please enter 1 for INT, 2 for DOUBLE or 3 for STRING");

        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("Please Enter Int Value");
            int value = int.Parse(Console.ReadLine());
            Console.WriteLine(value + 1);
        }
        else if (number == 2)
        {
            Console.WriteLine("Please Enter Double Value");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine(value + 1);
        }
        else if (number == 3)
        {
            Console.WriteLine("Please Enter String Value");
            string value = Console.ReadLine();
            Console.WriteLine(value + "*");
        }
        else
        {
            Console.WriteLine("Not a correct choice");
        } 
        ///*Second way - using switch case*/
       
        //Console.WriteLine("Please enter 1 for INT, 2 for DOUBLE or 3 for STRING");
        //int number = int.Parse(Console.ReadLine());

        //switch (number)
        //{
        //    case 1: Console.WriteLine("Please Enter Int Value");
        //        int intValue = int.Parse(Console.ReadLine());
        //        Console.WriteLine(intValue + 1);
        //        break;
        //    case 2: Console.WriteLine("Please Enter Double Value");
        //        double doubleValue = double.Parse(Console.ReadLine());
        //        Console.WriteLine(doubleValue + 1);
        //        break;
        //    case 3: Console.WriteLine("Please Enter String Value");
        //        string stringValue = Console.ReadLine();
        //        Console.WriteLine(stringValue + "*");
        //        break;

        //    default:
        //        Console.WriteLine("Not a correct choice");
        //        break;
        //}










    }
}