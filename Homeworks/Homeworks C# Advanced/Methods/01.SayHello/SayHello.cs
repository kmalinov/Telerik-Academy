using System;
class Program
{
    static void Main(string[] args)
    {
        SayHallo();

    }


    static void SayHallo()
    {

       string name = Console.ReadLine();
        Console.WriteLine("Hello {0}!",name);
      
    }
}
