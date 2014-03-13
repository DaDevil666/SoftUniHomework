using System;
    class StrAndObj
    {
        static void Main()
        {
            string hi = "Hello";
            string wrld = "World";
            object combine = hi + " " + wrld;
            string cast = (string) combine;
            Console.WriteLine(combine);
        }
    }