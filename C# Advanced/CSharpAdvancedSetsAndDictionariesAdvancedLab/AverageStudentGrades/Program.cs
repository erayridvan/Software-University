using System;
using System.Linq;
using System.Collections.Generic;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<double>>();

            for (int i = 0; i < index; i++)
            {
                string[] info = Console.ReadLine().Split(" ");
                string name = info[0];
                double grade = double.Parse(info[1]);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary[name] = new List<double>();
                }
                dictionary[name].Add(grade);
            }

            foreach (var name in dictionary)
            {
                Console.Write($"{name.Key} -> ");
                foreach (var item in name.Value)
                {
                    Console.Write($"{item:f2}" + " ");
                }
                Console.Write($"(avg: {name.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
