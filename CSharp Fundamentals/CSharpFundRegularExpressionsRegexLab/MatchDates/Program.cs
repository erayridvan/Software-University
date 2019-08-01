using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main()
        {
            var regex = @"[0-9]{2}(\.|-|\/)[A-z][a-z]{2}\1[0-9]{4}";

            var dates = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(dates, regex);

            Console.WriteLine();    
        }
    }
}
