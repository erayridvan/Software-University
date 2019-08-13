using System;
using System.Text.RegularExpressions;

namespace Password
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < index; i++)
            {
                string password = Console.ReadLine();
                string pattern = @"^([^\s]+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1";
                var regex = new Regex(@"^([^\s]+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1");
                //da opravq osven dadenite simvoli
                var isMatch = regex.IsMatch(password);

                if (isMatch)
                {
                    MatchCollection match = Regex.Matches(password, pattern);
                    string validPass = string.Empty;

                    foreach (Match item in match)
                    {
                        validPass = item.Groups[2].Value + item.Groups[3].Value + item.Groups[4].Value + item.Groups[5].Value;
                    }

                    Console.WriteLine($"Password: {validPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
