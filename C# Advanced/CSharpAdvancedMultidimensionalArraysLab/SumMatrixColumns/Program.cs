using System;

namespace SumMatrixColumns
{
    class Program
    {
        static void Main()
        {
            var dimentions = Console.ReadLine().Split(", ");
            var rows = int.Parse(dimentions[0]);
            var cols = int.Parse(dimentions[1]);
            
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowAsString = Console.ReadLine();
                var elements = rowAsString.Split(" ");
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(elements[col]);
                }
            }


            for (int col = 0; col < cols; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
