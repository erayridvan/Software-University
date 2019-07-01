using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celcius = double.Parse(Console.ReadLine());
            double fahrenheit = celcius * 1.8 + 32;

            Console.WriteLine("{0:F2}",fahrenheit);
        }
    }
}
