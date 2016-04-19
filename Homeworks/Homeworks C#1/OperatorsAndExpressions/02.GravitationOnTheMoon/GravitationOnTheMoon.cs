//Problem 2. Gravitation on the Moon

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.



using System;
class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your Kilograms");
        double kilos = double.Parse(Console.ReadLine());

        double kilosOnMoon = (kilos * 17) / 100;
        Console.WriteLine("If you are on the Moon, your Weight will be {0} kilograms",kilosOnMoon);
    }
}