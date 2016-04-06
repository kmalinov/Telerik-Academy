//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.



using System;
class ComparingFloats
{
    static void Main()
    {
        double firstFloatNumber;
        double secondFloatNumber;


      
        string firstNumber = Console.ReadLine();
       
        string secondNumber = Console.ReadLine();

        firstFloatNumber = double.Parse(firstNumber);
        secondFloatNumber = double.Parse(secondNumber);
  
    
        bool equal = Math.Abs(firstFloatNumber - secondFloatNumber) < 0.000001;
     
        if (equal==true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
        
         
        
        
        
        
        
        
       
    }
}
