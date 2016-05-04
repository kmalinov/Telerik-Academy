//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive



using System;
class PrimeNumberCheck
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());


        if (n == 1 || n == 2 || n == 3 || n == 5 || n == 7)
        {
            Console.WriteLine("true");
        }

        else if (n%2 == 0)
        {
            Console.WriteLine("false");
        }
        else if (n%3 == 0)
        {
            Console.WriteLine("false");
        }
        else if (n%5==0)
        {
            Console.WriteLine("false");
        }
        else if (n%7 == 0)
        {
            Console.WriteLine("false");
        }
        else
        {
            Console.WriteLine("true");
        }
    }
}






//        Console.Title = "Prime Number Check";

//        Console.Write("Enter positive integer number (between 0 and 100): ");
//        int number = int.Parse(Console.ReadLine());
//        bool isTrue = true;

//        Console.WriteLine(new string('-', 53));
//        Console.Write("The number is primr! --> ");
//        if (number > 1 && number <= 100)
//        {
//            for (int i = 2; i < 10; i++)
//            {
//                if (number != i)
//                {
//                    if (number % i == 0)
//                    {
//                        isTrue = false;
//                    }
//                }

//            }
//            Console.WriteLine(isTrue);
//        }
//        else
//        {
//            Console.WriteLine(isTrue = false);
//        }
//    }
//}