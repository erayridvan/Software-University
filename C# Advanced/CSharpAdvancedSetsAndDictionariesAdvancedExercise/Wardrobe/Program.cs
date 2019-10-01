using System;
using System.Collections.Generic;
using System.Linq;

namespace Wardrobe
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" -> ");
                string currentColor = line[0];
                string[] clothes = line[1].Split(",",StringSplitOptions.RemoveEmptyEntries);

                if (!wardrobe.ContainsKey(currentColor))
                {
                    wardrobe[currentColor] = new Dictionary<string, int>();
                }

                for (int k = 0; k < clothes.Length; k++)
                {
                    if (!wardrobe[currentColor].ContainsKey(clothes[k]))
                    {
                        wardrobe[currentColor][clothes[k]] = 1;
                    }
                    else
                    {
                        wardrobe[currentColor][clothes[k]]++;
                    }
                }
            }

            string[] clothSearch = Console.ReadLine().Split(" ");
            string color = clothSearch[0];
            string dress = clothSearch[1];

            foreach (var col in wardrobe)
            {
                Console.WriteLine($"{col.Key} clothes:");
                foreach (var cloth in col.Value)
                {
                    if (color==col.Key && dress==cloth.Key)
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
