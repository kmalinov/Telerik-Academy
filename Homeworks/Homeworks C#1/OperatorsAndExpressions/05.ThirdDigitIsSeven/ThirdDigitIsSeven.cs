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
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("No");
            }
            
        }
    }