//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need 
//to learn how to parse dates and times.




//using System;
//using System.Globalization;
//class BeerTime
//{
//    static void Main()
//    {
//        Console.WriteLine("Please Enter the date ant time, to check if it is suituble to beer time");
//        DateTime myDrinkTime = DateTime.Parse(Console.ReadLine());
//        string startDrink = "01:00 PM";
//        string stopDrink = "3:00 AM";
//        DateTime startDrinkBeer = DateTime.ParseExact(startDrink, "h:mm tt", CultureInfo.InvariantCulture);
//        DateTime stopDrinkBeer = DateTime.ParseExact(stopDrink, "h:mm tt", CultureInfo.InvariantCulture);
//        int result = DateTime.Compare(startDrinkBeer,myDrinkTime);
//        int result2 = DateTime.Compare(myDrinkTime,stopDrinkBeer);
//        if (result > 0 && result2 <= 0)
//        {
//            Console.WriteLine("It is beer time");
//        }
//    }
//}
using System;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;

            string birthday = Console.ReadLine();
            int inputYear = int.Parse(birthday.Substring(6, 4));
            int inputMonth = int.Parse(birthday.Substring(0, 2));
            int age = date.Year - inputYear;
            if (inputMonth > date.Month)
            {
                age--;
            }

            int ageAfterTenYears = age + 10;

            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);
        }
    }
}