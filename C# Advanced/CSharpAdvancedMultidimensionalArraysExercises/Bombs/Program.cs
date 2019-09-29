using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main()
        {
            int dimention = int.Parse(Console.ReadLine());
            var matrix = new int[dimention, dimention];


            InitializationMatrix(matrix, dimention);

            string[] coordinates = Console.ReadLine()
                .Split(" ")
                .ToArray();

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentCoordinates = coordinates[i].Split(",").Select(int.Parse).ToArray();

                if (CoordinatesCheck(matrix, currentCoordinates))
                {
                    Explotions(matrix, currentCoordinates);
                }
            }

            AliveCells(matrix);
            PrintMatrix(matrix);
            ;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void AliveCells(int[,] matrix)
        {
            int aliceCells = 0;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentNumber = matrix[row, col];

                    if (currentNumber > 0)
                    {
                        aliceCells++;
                        sum += currentNumber;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliceCells}");
            Console.WriteLine($"Sum: {sum}");
        }

        private static bool CoordinatesCheck(int[,] matrix, int[] currentCoordinates)
        {
            int row = currentCoordinates[0];
            int col = currentCoordinates[1];

            if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix.GetLength(1))
            {
                if (matrix[row,col]>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }

        private static void Explotions(int[,] matrix, int[] currentCoordinates)
        {
            int row = currentCoordinates[0];
            int col = currentCoordinates[1];

            if (row - 1 >= 0 && col - 1 >= 0) // upleft diagonal ready
            {
                if (matrix[row - 1, col - 1] > 0)
                {
                    matrix[row - 1, col - 1] -= matrix[row, col];
                }
            }

            if (col - 1 >= 0) // left one ready
            {
                if (matrix[row, col - 1]>0)
                {
                    matrix[row, col - 1] -= matrix[row, col];
                }
            }

            if (row + 1 >= 0 && col - 1 >= 0 && row + 1 < matrix.GetLength(0)) // downleft diagonal ready
            {
                if (matrix[row + 1, col - 1]>0)
                {
                    matrix[row + 1, col - 1] -= matrix[row, col];
                }
            }

            if (row - 1 >= 0) // up ready
            {
                if (matrix[row - 1, col]>0)
                {
                    matrix[row - 1, col] -= matrix[row, col];
                }    
            }

            if (row + 1 < matrix.GetLength(0)) // down ready
            {
                if (matrix[row + 1, col]>0)
                {
                    matrix[row + 1, col] -= matrix[row, col];
                }
            }

            //if (row - 1 >= 0 && col + 1 >= 0 && row - 1 <=matrix.GetLength(0)&& col + 1 <= matrix.GetLength(1)) // upright diagonal
            //{
            //    if (matrix[row - 1, col + 1]>0) // to do 
            //    {
            //        matrix[row - 1, col + 1] -= matrix[row, col];
            //    }
            //}

            if (row - 1 >= 0 && col + 1 < matrix.GetLength(1)) // upright diagonal ready
            {
                if (matrix[row - 1, col + 1]>0)
                {
                    matrix[row - 1, col + 1] -= matrix[row, col];
                }
            }

            if (col + 1 < matrix.GetLength(1)) // right one ready
            {
                if (matrix[row, col + 1]>0)
                {
                    matrix[row, col + 1] -= matrix[row, col];
                }
            }

            if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1)) // downright diagonal
            {
                if (matrix[row + 1, col + 1]>0)
                {
                    matrix[row + 1, col + 1] -= matrix[row, col];
                }
            }

            if (matrix[row, col]>0)
            {
                matrix[row, col] -= matrix[row, col];
            }
        }

        private static void InitializationMatrix(int[,] matrix, int dimention)
        {
            for (int row = 0; row < dimention; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < dimention; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
        }
    }
}
