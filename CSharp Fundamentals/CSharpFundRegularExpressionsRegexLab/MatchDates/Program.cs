using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main()
        {
            string regex = @"\b(?<day>\d{2})([\/| -|\.])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection matchedDates = Regex.Matches(dates, regex);

            foreach (Match matches in matchedDates)
            {
                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}",matches.Groups[2].Value,matches.Groups[3].Value,matches.Groups[4].Value);
            }
        }
    }
}
