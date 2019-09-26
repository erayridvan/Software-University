using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            if (rows < 2 || cols < 2)
            {
                return;
            }

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < rows - 3 + 1; row++)
            {
                for (int col = 0; col < cols - 3 + 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col+1] + matrix[row, col+2]
                                    +matrix[row+1, col] + matrix[row+1, col+1] + matrix[row+1, col+2]
                                   + matrix[row+2, col] + matrix[row+2, col+1] + matrix[row+2, col+2];

                    if (currentSum>sum)
                    {
                        sum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }


            Console.WriteLine($"Sum = {sum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write($"{matrix[maxRow+row, maxCol+col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
