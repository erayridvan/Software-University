using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            MatricPrinter(number);
        }

        static void MatricPrinter(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    Console.Write(number+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
