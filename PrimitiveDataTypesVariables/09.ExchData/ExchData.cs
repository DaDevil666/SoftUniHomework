using System;
    class ExchData
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("The Non exchanged variable of a is: {0}", a);
            Console.WriteLine("The Non exchanged variable of b is: {0}", b);
            int exchange1 = b;
            int exchange2 = (a + b) - b;
            Console.WriteLine(exchange1);
            Console.WriteLine(exchange2);
        }
    }

