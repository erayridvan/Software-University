using System;

namespace SignOfIntegerNumbers
{
    class Program
    {
        static void Main()
        {
            PrintSign();
        }
        static void PrintSign()
        {
            int a = int.Parse(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine($"The number {a} is positive.");
            }
            else if (a<0)
            {
                Console.WriteLine($"The number {a} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {a} is zero.");
            }
        }
    }
}
