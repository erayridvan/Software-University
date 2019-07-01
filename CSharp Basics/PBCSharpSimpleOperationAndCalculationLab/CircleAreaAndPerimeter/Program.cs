using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            double area = Math.PI * a * a;
            double perimetyr = 2 * Math.PI * a;

            Console.WriteLine("{0:F2}" ,area);
            Console.WriteLine("{0:F2}",perimetyr);
        }
    }
}
