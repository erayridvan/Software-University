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
            double totalMoneySpend = 0;

            string pattern = @">>([A-Za-z]+)<<([0-9\.]+)!([0-9]+)";
            string command = string.Empty;

            var regex = new Regex(@">>([A-Za-z]+)<<([0-9\.]+)!([0-9]+)");
            while ((command=Console.ReadLine()) != "Purchase")
            {
                if (regex.IsMatch(command))
                {
                    Match matches = regex.Match(command);

                    boughtFurniter.Add(matches.Groups[1].Value.ToString());
                    double price = double.Parse(matches.Groups[2].Value.ToString());
                    int quantity = int.Parse(matches.Groups[3].Value.ToString());

                    totalMoneySpend += (price * quantity);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var item in boughtFurniter)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoneySpend:f2}");
        }
    }
}
