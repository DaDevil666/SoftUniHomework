using System;

    class OddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter your number to check if it is Odd or Even: ");
            int num = int.Parse(Console.ReadLine());
            bool result = ((num % 2) == 0);
            Console.WriteLine(result);
        }
    }
