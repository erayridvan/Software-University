using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Race
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> racersAndDistance = new Dictionary<string, int>();

            List<string> participant = Console.ReadLine().Split(",").Select(t=>t.Trim()).ToList();
            string info = string.Empty;

            while ((info = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;
                int distance = 0;

                for (int i = 0; i < info.Length; i++)
                {
                    char currentSymbol = info[i];

                    if (char.IsDigit(currentSymbol))
                    {
                        distance += int.Parse(currentSymbol.ToString());
                    }
                    else if (char.IsLetter(currentSymbol))
                    {
                        name += currentSymbol;
                    }
                }

                if (participant.Contains(name))
                {
                    if (!racersAndDistance.ContainsKey(name))
                    {
                        racersAndDistance[name] = distance;
                    }
                    else
                    {
                        racersAndDistance[name] += distance;
                    }
                    
                }

                name = string.Empty;
                distance = 0;
            }

            int count = 0;
            foreach (var racer in racersAndDistance.OrderByDescending(n=>n.Value))
            {
                count++;
                if (count==4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{count}st place: {racer.Key}");
                }
            }
        }
    }
}
