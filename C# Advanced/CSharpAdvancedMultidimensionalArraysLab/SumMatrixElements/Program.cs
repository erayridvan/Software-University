using System;

namespace SumMatrixElements
{
    class Program
    {
        static void Main()
        {
            var dimentions = Console.ReadLine().Split(", ");
            var rows = int.Parse(dimentions[0]);
            var cols = int.Parse(dimentions[1]);
            long sum =0;

            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var elements = rowAsString.Split(", ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = int.Parse(elements[col]);
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
