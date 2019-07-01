using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSide = int.Parse(Console.ReadLine());
            int area = squareSide * squareSide;

            Console.WriteLine(area);
        }
    }
}
