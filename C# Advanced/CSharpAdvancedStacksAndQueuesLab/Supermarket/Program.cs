using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main()
        {
            string name = string.Empty;
            Queue<string> names = new Queue<string>();

            while ((name=Console.ReadLine()) != "End")
            {
                if (name!="Paid")
                {
                    names.Enqueue(name);
                }
                else if(name=="Paid")
                {
                    int index = names.Count();

                    for (int i = 0; i < index; i++)
                    {
                        string currentName = names.Peek();
                        Console.WriteLine(currentName);
                        names.Dequeue();
                    }
                    names.Clear();
                }
            }
                Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
