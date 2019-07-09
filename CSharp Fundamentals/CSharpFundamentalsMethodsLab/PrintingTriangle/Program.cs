using System;

namespace PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
                PrintLine(1, i);

            for (int k = 1; k <= a-1; k++)
                PrintLine(1, a-k);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
    }
}
