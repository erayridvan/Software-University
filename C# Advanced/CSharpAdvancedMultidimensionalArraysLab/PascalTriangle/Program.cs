using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][]; 

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];
            }

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][pascalTriangle[i].Length - 1] = 1;
                for (int j = 1; j < pascalTriangle[i].Length-1; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i-1][j] + pascalTriangle[i-1][j-1];
                }
            } 

            foreach (var array in pascalTriangle)
            {
                foreach (var number in array)
                {
                    Console.Write(number+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
