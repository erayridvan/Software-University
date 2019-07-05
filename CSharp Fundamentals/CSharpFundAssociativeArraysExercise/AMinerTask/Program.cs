using System;
using System.Linq;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, int>();
            
            string text = Console.ReadLine();
            while (text != "stop")
            {
                if (!(dict.ContainsKey(text)))
                {
                    dict[text] = int.Parse(Console.ReadLine());
                }
                else
                {
                    dict[text] += int.Parse(Console.ReadLine());
                }
                text = Console.ReadLine();
            }

            foreach (var resource in dict)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
