//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;
class Rectangles
{
    static void Main()
    {

        Console.WriteLine("Please Enter the lenght of the width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter the lenght of the height");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width * height;

        Console.WriteLine("This Rectangle with width {0} and height {1} has perimeter {2} and area {3}",width,height,perimeter,area);
    }
}
