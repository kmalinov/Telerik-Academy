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
using System;
class Zadacha11
{

    static void Main()
    {
        string dateOfBirth = Console.ReadLine();
        DateTime today = DateTime.Today;
        int yearOfBirth = int.Parse(dateOfBirth.Substring(6, 4));
        int monthOfBirth = int.Parse(dateOfBirth.Substring(3, 2));
        int todayDay = int.Parse(dateOfBirth.Substring(0, 2));
        int myAge = today.Year - yearOfBirth;

        if (monthOfBirth <= today.Month && todayDay <= today.Day)
        {
            Console.WriteLine(myAge);
            Console.WriteLine(myAge + 10);

        }

        else
        {
            Console.WriteLine(myAge - 1);
            Console.WriteLine(myAge + 9);
        }
    }
}
    


