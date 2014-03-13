using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter your number to check if it divides by 7 and 5:");
        int num = int.Parse(Console.ReadLine());
        int result = Math.Abs(num % 35);
        bool boolresult = result == 0;
        Console.WriteLine(boolresult);
    }
}