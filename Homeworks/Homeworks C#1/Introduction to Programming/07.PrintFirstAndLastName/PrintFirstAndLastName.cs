//Problem 7. Print First and Last Name
//Create console application that prints your first and last name, each at a separate line.



using System;
class PrintFirstLastName

{
    static void Main()
    {
        string firstName = "Konstantin";
        string lastName = "Kostadinov";
        int age = 17;

        Console.WriteLine("My name is:");
        Console.WriteLine("{0}", firstName);
        Console.WriteLine("{0}, and I am {1} years old!", lastName, age);
        // Console.WriteLine("Konstantin Malinov");
    }
}
