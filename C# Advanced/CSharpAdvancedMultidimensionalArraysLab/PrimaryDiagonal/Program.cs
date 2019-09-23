using System;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                var rowAsString = Console.ReadLine();
                var elements = rowAsString.Split(" ");
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = int.Parse(elements[col]);
                }
            }

            int diagonalSum = 0;
            for (int i = 0; i < matrixSize; i++)
            {
                diagonalSum += matrix[i,i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
