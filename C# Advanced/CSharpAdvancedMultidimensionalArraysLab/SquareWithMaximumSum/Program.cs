using System;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split(", ");
            var rows = int.Parse(dimensions[0]);
            var cols = int.Parse(dimensions[1]);

            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine().Split(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowAsString[col]);
                }
            }

            int subMatrixMaxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                int subMatrixSum = 0;
                for (int col = 0; col < matrix.GetLength(1)-1; col++)
                {
                    subMatrixSum = matrix[row, col] + 
                                    matrix[row, col + 1] + 
                                    matrix[row + 1, col] + 
                                    matrix[row + 1, col + 1];

                    if (subMatrixSum>subMatrixMaxSum)
                    {
                        subMatrixMaxSum = subMatrixSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }

                }
            }

            Console.WriteLine($"{matrix[maxSumRow,maxSumCol]} {matrix[maxSumRow, maxSumCol+1]}");
            Console.WriteLine($"{matrix[maxSumRow+1, maxSumCol]} {matrix[maxSumRow+1, maxSumCol+1]}");
            Console.WriteLine(subMatrixMaxSum);
        }
    }
}
