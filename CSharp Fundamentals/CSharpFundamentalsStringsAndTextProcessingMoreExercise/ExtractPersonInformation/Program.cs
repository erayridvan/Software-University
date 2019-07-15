using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main()
        {
            string text = "@eray|";
            char[] symbols = text.ToCharArray();
            symbols = symbols.SkipWhile(n => n == '@').SkipWhile(l=>l=='|').ToArray();
            Console.WriteLine(symbols);
        }
    }
}
