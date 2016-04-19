//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point



using System;
class CirclePerimeterAndArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double areaS = Math.PI * radius*radius;
        double perimeter = 2 * Math.PI * radius;


        Console.WriteLine("The Area of a circle formatted with 2 digits after the decimal point is: {0:0.00}", areaS);
        Console.WriteLine("The Perimeter of a circle formatted with 2 digits after the decimal point is: {0:0.00}", perimeter);
    }
}