using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main()
        {
            List<string> boughtFurniter = new List<string>();
            int totalMoneySpend = 0;

            string pattern = @"([A-za-z]+)<<([0-9]+\.*[0-9]*)!([0-9])";
            string command = string.Empty;

            var regex = new Regex(@"([A-za-z]+)<<([0-9]+\.*[0-9]*)!([0-9])");
            while ((command=Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(command))
                {
                    MatchCollection matches = Regex.Matches(command, pattern);
                    
                }
            }

            Console.WriteLine();    
        }
    }
}
