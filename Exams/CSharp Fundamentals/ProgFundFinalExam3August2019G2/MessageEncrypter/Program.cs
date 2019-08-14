using System;
using System.Text.RegularExpressions;

namespace MessageEncrypter
{
    class Program
    {
        static void Main()
        {
            int times = int.Parse(Console.ReadLine());
            var pattern = new Regex(@"(\*|@)(?<name>[A-Z][a-z]{2,})\1: \[(?<firstLetter>[A-za-z])\]\|\[(?<secondLetter>[A-Za-z])\]\|\[(?<thirdLetter>[A-Za-z])\]\|$");

            for (int i = 0; i < times; i++)
            {
                string text = Console.ReadLine();

                var matches = pattern.Match(text);


                if (matches.Success)
                {
                    string name = matches.Groups["name"].Value;
                    char letter = char.Parse(matches.Groups["firstLetter"].Value);
                    char letter1 = char.Parse(matches.Groups["secondLetter"].Value);
                    char letter2 = char.Parse(matches.Groups["thirdLetter"].Value);

                    Console.WriteLine($"{name}: {(int)letter} {(int)letter1} {(int)letter2}");

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }
        }
    }
}
