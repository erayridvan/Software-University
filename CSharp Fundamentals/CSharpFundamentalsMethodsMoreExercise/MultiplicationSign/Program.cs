using System;

namespace Multiplication_sign
{
    class Program
    {
        static int PositiveNegative(int num1, int num2, int num3)
        {
            int br = 0;
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                br = -1;
                return br;

            }
            
            if (num1 > 0)
                br++;
            if (num2 > 0)
                br++;
            if (num3 > 0)
                br++;

            return br;

        }
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int br = PositiveNegative(firstNum, secondNum, thirdNum);
            if (br == -1)
                Console.WriteLine("zero");
            else if (br % 2 == 0)
                Console.WriteLine("negative");
            else if (br % 2 != 0)
                Console.WriteLine("positive");

        }
    }
}