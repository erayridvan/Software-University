using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main()
        {

            var pattern = new Regex("\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matchedNames = pattern.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
