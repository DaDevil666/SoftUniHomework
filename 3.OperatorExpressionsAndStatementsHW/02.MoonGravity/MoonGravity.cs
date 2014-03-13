using System;
class MoonGravity
{
    static void Main()
    {
        Console.WriteLine("Enter your current weight in kg: ");
        int kg = int.Parse(Console.ReadLine());
        double moonWeight = Math.Abs(kg * 0.17);
        Console.WriteLine("Your weight on the moon would be(in kg): {0}", moonWeight);
    }
}
