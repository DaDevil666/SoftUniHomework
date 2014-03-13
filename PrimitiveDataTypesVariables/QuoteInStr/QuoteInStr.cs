using System;
class QuoteInStr
{
    static void Main()
    {
        string quote = "The use of quotations causes difficulties.";
        string quote1 = "The \"use\" of quotations causes difficulties";
        string quote2 = @"The ""use"" of quotations causes difficulties";
        Console.WriteLine(quote);
        Console.WriteLine(quote1);
        Console.WriteLine(quote2);
    }
}