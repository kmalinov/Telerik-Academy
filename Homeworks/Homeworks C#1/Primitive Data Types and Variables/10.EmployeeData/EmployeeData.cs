//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names.
//Print the data at the console.

using System;
class EmployeeData
{
    static void Main()
    {

        Console.WriteLine("Please Enter Your First Name");
        string firstName = Console.ReadLine();
        Console.WriteLine("Please Enter Your Second Name");
        string secondName = Console.ReadLine();
        Console.WriteLine("Please Enter Your Gender");
        string age = Console.ReadLine();
        Console.WriteLine("Please Enter Your Age");
        string gender = Console.ReadLine();
        Console.WriteLine("Please Enter Your Personal ID Number");
        string  personalIDNumber = Console.ReadLine();
        Console.WriteLine("Please Enter Your Unique Employee Number");
        string uniqueEmployeeNumber = Console.ReadLine();

      //  Console.WriteLine(firstName +"\n"+secondName +"\n"+age +"\n"+ gender + "\n"+ personalIDNumber+"\n"+uniqueEmployeeNumber);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("     first name: {0}",firstName);
        Console.WriteLine("    second name: {0}",secondName);
        Console.WriteLine("            age: {0}",age);
        Console.WriteLine("         gender: {0}",gender);
        Console.WriteLine("personal number: {0}",personalIDNumber);
        Console.WriteLine("employee number: {0}",uniqueEmployeeNumber);
    }
}
 