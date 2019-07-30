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
            var pattern = new Regex("[A - Z][a - z] + [A - Z][a - z] +");

            string names = Console.ReadLine();

            var matchedNames = pattern.Matches(names);

            foreach (Match name in matchedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
