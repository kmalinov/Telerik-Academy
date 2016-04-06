//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
//3 credit card numbers associated with the account.
// the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.



using System;
class Program
{
    static void Main()
    {

        string customerFName = ("Ivan");
        string customerMName = ("Ivanov");
        string customerLName = ("Ivanov");
        decimal amount = 1200700m;
        string bankName = "Bank of America";
        string IBAN = "BG172017201720";
        ulong firstCreditCard = 210721072107;
        ulong secondCreditCad = 702170217021;
        ulong thirdCreditCard = 172017201720;
        Console.WriteLine("          Name: {0} {1} {2}",customerFName,customerMName,customerLName);
        Console.WriteLine("     Bank name: {0}",bankName);
        Console.WriteLine("          IBAN: {0}",IBAN );
        Console.WriteLine("Credit card(s): {0}\n                {1}\n                {2}", firstCreditCard, secondCreditCad, thirdCreditCard);


  


    }

}