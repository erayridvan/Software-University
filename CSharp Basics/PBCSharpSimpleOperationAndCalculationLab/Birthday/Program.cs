using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int witdh = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double area = lenght * witdh * height;
            double totalLitres = area * 0.001;
            double realLitres = totalLitres * (1 - percent / 100);

            Console.WriteLine("{0:F3}",realLitres);
        }
    }
}
