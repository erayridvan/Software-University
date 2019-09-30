using System;
using System.Collections.Generic;
using System.Linq;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < index; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string continent = info[0];
                string counrty = info[1];
                string city = info[2];

                if (!dictionary.ContainsKey(continent))
                {
                    dictionary[continent] = new Dictionary<string, List<string>>();
                    dictionary[continent][counrty] = new List<string>();
                }
                else if (!dictionary[continent].ContainsKey(counrty))
                {
                    dictionary[continent][counrty] = new List<string>();
                }
                dictionary[continent][counrty].Add(city);
            }

            foreach (var cont in dictionary)
            {
                Console.WriteLine($"{cont.Key}:");
                foreach (var coun in cont.Value)
                {
                    Console.Write($"  {coun.Key} -> {string.Join(", ",coun.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
