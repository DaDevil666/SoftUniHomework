using System;
class thirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if it's thid digit is 7: ");
        int num = int.Parse(Console.ReadLine());
        bool result = (num / 100) % 7 == 0;
        Console.WriteLine(result);
    }
}
