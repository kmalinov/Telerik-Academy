//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.


using System;
 class ThirdDigitIsSeven
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
           
            if ((a / 100) % 10 == 7)
            {
                Console.WriteLine("true");
            }

            else if ((a / 100) % 10 == 1)
            {
                Console.WriteLine("false"+ " " +1);
            }
            else if ((a / 100) % 10 == 2)
            {
                Console.WriteLine("false" + " " + 2);
            }
            else if ((a / 100) % 10 == 3)
            {
                Console.WriteLine("false" + " " + 3);
            }
            else if ((a / 100) % 10 == 4)
            {
                Console.WriteLine("false" + " " + 4);
            }
            else if ((a / 100) % 10 == 5)
            {
                Console.WriteLine("false" + " " + 5);
            }
            else if ((a / 100) % 10 == 6)
            {
                Console.WriteLine("false" + " " + 6);
            }
            else if ((a / 100) % 10 == 8)
            {
                Console.WriteLine("false" + " " + 8);
            }
            else if ((a / 100) % 10 == 9)
            {
                Console.WriteLine("false" + " " + 9);
            }
            else if ((a / 100) % 10 == 0)
            {
                Console.WriteLine("false" + " " + 0);
            }
        }
    }