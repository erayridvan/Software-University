using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            var matrix = new double[rows][];

            InitializationMatrix(matrix, rows);
            AnalyzingMatrix(matrix, rows);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] args = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string operation = args[0];
                int row = int.Parse(args[1]);
                int col = int.Parse(args[2]);
                int value = int.Parse(args[3]);


                if (row >= 0 && row < matrix.Length && col >= 0 && col< matrix[row].Length)
                {
                    if (operation == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    else if (operation == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            foreach (var numbers in matrix)
            {
                Console.WriteLine($"{string.Join(" ", numbers)} ");
            }
        }

        private static void AnalyzingMatrix(double[][] matrix, int rows)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row].GetLength(0) == matrix[row + 1].GetLength(0))
                {
                    for (int i = 0; i < matrix[row].GetLength(0); i++)
                    {
                        matrix[row][i] *= 2;
                        matrix[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < matrix[row].GetLength(0); i++)
                    {
                        matrix[row][i] /= 2;
                    }

                    for (int i = 0; i < matrix[row + 1].GetLength(0); i++)
                    {
                        matrix[row + 1][i] /= 2;
                    }
                }
            }
        }

        private static void InitializationMatrix(double[][] matrix, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                double[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[row] = numbers;
            }
        }
    }
}
