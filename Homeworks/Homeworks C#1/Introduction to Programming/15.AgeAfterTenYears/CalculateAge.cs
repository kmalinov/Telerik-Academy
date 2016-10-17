//Problem 15.* Age after 10 Years
//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.



//using System;
//using System.Globalization;
//class Zadacha11
//    {
//        static void Main()
//        {
            
//            string birthDate = Console.ReadLine();
//            DateTime myBirthDate = DateTime.ParseExact(birthDate, "mm.dd.yyyy", CultureInfo.InvariantCulture);


//            DateTime today = DateTime.Now;
//            int myAge = today.Year - myBirthDate;    
     
//            }
          


//        }
//using System;
//class Zadacha11
//{

//    static void Main()
//    {
//        string dateOfBirth = Console.ReadLine();
//        DateTime today = DateTime.Today;
//        int yearOfBirth = int.Parse(dateOfBirth.Substring(6, 4));
//        int monthOfBirth = int.Parse(dateOfBirth.Substring(3, 2));
//        int todayDay = int.Parse(dateOfBirth.Substring(0, 2));
//        int myAge = today.Year - yearOfBirth;

//        if (monthOfBirth <= today.Month && todayDay <= today.Day)
//        {
//            Console.WriteLine(myAge);
//            Console.WriteLine(myAge + 10);

//        }

//        else
//        {
//            Console.WriteLine(myAge - 1);
//            Console.WriteLine(myAge + 9);
//        }
//    }
//}

using System;
using System.Threading;
using System.Globalization;

class Age
{
    static void Main(string[] args)
    {
        string dateStr = Console.ReadLine();
        DateTime date = DateTime.ParseExact(dateStr, "MM.dd.yyyy", CultureInfo.InvariantCulture);
        //  Console.WriteLine(date.ToString("dd.MM.yyyy"));
        DateTime today = DateTime.Today;
        if (date.Day > today.Day)
        {
            Console.WriteLine("{0:F0}", ((today - date).Days / 365.25) - 1);
            Console.WriteLine("{0:F0}", ((today - date).Days / 365.25) + 9);
        }

        else
        {
            Console.WriteLine("{0:F0}", (today - date).Days / 365.25);
            Console.WriteLine("{0:F0}", ((today - date).Days / 365.25) + 10);

        }


    }
}

