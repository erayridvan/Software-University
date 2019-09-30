using System;
using System.Collections.Generic;
using System.Linq;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main()
        {
            var names =new HashSet<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var currentName in names)
            {
                Console.WriteLine(currentName);
            }
        }
    }
}
