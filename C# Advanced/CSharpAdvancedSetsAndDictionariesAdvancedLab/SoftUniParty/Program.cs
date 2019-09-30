using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniParty
{
    class Program
    {
        static void Main()
        {
            var guest = new HashSet<string>();
            var vipGuest = new HashSet<string>();
            var input = Console.ReadLine();

            while (input!="PARTY")
            {
                if(Regex.IsMatch(input, @"^\d"))
                {
                    vipGuest.Add(input);
                }
                else
                {
                    guest.Add(input);
                }
                input = Console.ReadLine();
            }

            var comingGuest = Console.ReadLine();

            while (comingGuest!="END")
            {
                if (guest.Contains(comingGuest))
                {
                    guest.Remove(comingGuest);
                }
                else if (vipGuest.Contains(comingGuest))
                {
                    vipGuest.Remove(comingGuest);
                }
                comingGuest = Console.ReadLine();
            }

            Console.WriteLine(guest.Count+vipGuest.Count);
            foreach (var gues in vipGuest)
            {
                Console.WriteLine(gues);
            }
            foreach (var gues in guest)
            {
                Console.WriteLine(gues);
            }
        }
    }
}
