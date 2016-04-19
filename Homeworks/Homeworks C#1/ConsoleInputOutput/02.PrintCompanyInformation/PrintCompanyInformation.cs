//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.



using System;
class PrintCompanyInformation
{
    static void Main()
    {

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Please Enter Company Name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please Enter Company Address: ");
        string address = Console.ReadLine();
        Console.WriteLine("Please Enter Company Phone: ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Please Enter Company Fax: ");
        string faxNumber = Console.ReadLine();
             if (faxNumber.Length == 0)
                {
                    faxNumber = "(No Fax)";
                }
        Console.WriteLine("Please Enter Company Web Address: ");
        string webAddress = Console.ReadLine();
        Console.WriteLine("Please Enter Company Manager First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Please Enter Company Manager Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Please Enter Company Manager Age: ");
        string managerAge = Console.ReadLine();
        Console.WriteLine("Please Enter Company Manager Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("{0}" + "\n" +
        "Address: {1}" + "\n" + "Tel. {2}" + "\n" + "Fax: {3}" + "\n" + "Web Site: {4}",companyName, address,companyPhone, faxNumber, webAddress);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",managerFirstName,managerLastName,managerAge,managerPhone );




    }
}
