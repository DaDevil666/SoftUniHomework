using System;

class Add10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        int futureAge = age + 10;
        Console.WriteLine("Your age in 10 years will be: " + futureAge);
    }
}
