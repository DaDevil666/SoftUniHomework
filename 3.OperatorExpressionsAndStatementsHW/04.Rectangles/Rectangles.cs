using System;
class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width and height(lenght) of a rectangle to calulate it's area and perimeter");
        Console.WriteLine("Enter the width: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height(lenght): ");
        int lenght = int.Parse(Console.ReadLine());
        double area = (lenght * width);
        double perimeter = 2*(lenght + width);
        Console.WriteLine("The area of the rectangle is: {0} ,and the perimeter is: {1}", area, perimeter);
    }
}
