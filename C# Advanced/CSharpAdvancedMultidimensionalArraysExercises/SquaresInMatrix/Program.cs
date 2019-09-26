using System;
using System.Linq;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            if (rows<0 || cols<0)
            {
                Console.WriteLine(0);
                return; 
            }

            var matrix = new char[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                char[] letters = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = letters[col]; ;
                }
            }

            int counter = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    if (matrix[row,col]==matrix[row,col+1] &&
                        matrix[row+1,col] == matrix[row+1,col+1] &&
                        matrix[row, col] == matrix[row+1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
