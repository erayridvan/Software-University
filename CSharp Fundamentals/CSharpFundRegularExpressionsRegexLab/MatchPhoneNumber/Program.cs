using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string regex = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}";

            string phones = Console.ReadLine();

            MatchCollection matchedPhones = Regex.Matches(phones, regex);

            var phoneMatched = matchedPhones
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                 .ToArray();

            Console.WriteLine(string.Join(", ",phoneMatched));
        }
    }
}
