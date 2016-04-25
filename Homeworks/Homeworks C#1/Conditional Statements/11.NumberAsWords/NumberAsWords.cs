//Problem 11.* Number as Words

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;
class NumberAsWords
{
    static void Main()
    {


        Console.WriteLine("Please Enter Number from 0 to 999");
        string numbers = Console.ReadLine();
        string singles = numbers;
        string doubles = numbers;
        string thirties = numbers;
        foreach (var a in numbers)
        {

        }

            if (numbers.Length == 3)
            {   

                switch (thirties)
                {
                    case "100":
                        Console.WriteLine("One Hundred");
                        break;
                    case "200":
                        Console.WriteLine("Two Hundred");
                        break;
                    case "300":
                        Console.WriteLine("Three Hundred");
                        break;
                    case "400":
                        Console.WriteLine("Four Hundred");
                        break;
                    case "500":
                        Console.WriteLine("Five Hundred");
                        break;
                    case "600":
                        Console.WriteLine("Six Hundred");
                        break;
                    case "700":
                        Console.WriteLine("Seven Hundred");
                        break;
                    case "800":
                        Console.WriteLine("Eight Hundred");
                        break;
                    case "900":
                        Console.WriteLine("Nine Hundred");
                        break;
                       
                }
                

            }
            else if (numbers.Length == 2)
            {
                switch (doubles)
                {
                    case "10":
                        Console.WriteLine("Ten");
                        break;
                    case "11":
                        Console.WriteLine("Eleven");
                        break;
                    case "12":
                        Console.WriteLine("Twelve");
                        break;
                    case "13":
                        Console.WriteLine("Thirdteen");
                        break;
                    case "14":
                        Console.WriteLine("Fourteen");
                        break;
                    case "15":
                        Console.WriteLine("Fivteen");
                        break;
                    case "16":
                        Console.WriteLine("Sixteen");
                        break;
                    case "17":
                        Console.WriteLine("Seventeen");
                        break;
                    case "18":
                        Console.WriteLine("Eighteen");
                        break;
                    case "19":
                        Console.WriteLine("Nineteen");
                        break;
                    case "20":
                        Console.WriteLine("Twenty");
                        break;
                }
            }

            else if (numbers.Length == 1)
            {
                switch (singles)
                {
                    case "0":
                        Console.WriteLine("Zero");
                        break;
                    case "1":
                        Console.WriteLine("One");
                        break;
                    case "2":
                        Console.WriteLine("Two");
                        break;
                    case "3":
                        Console.WriteLine("Three");
                        break;
                    case "4":
                        Console.WriteLine("Four");
                        break;
                    case "5":
                        Console.WriteLine("Five");
                        break;
                    case "6":
                        Console.WriteLine("Six");
                        break;
                    case "7":
                        Console.WriteLine("Seven");
                        break;
                    case "8":
                        Console.WriteLine("Eight");
                        break;
                    case "9":
                        Console.WriteLine("Nine");
                        break;

                }

            }

        }

    
}

