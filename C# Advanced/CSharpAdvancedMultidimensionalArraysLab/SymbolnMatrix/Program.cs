using System;

namespace SymbolnMatrix
{
    class Program
    {
        static void Main()
        {
            int matrixSize = int.Parse(Console.ReadLine());

            var matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                var rowAsString = Console.ReadLine();
                //var elements = rowAsString.Split(" ");
                for (int col = 0; col < matrixSize; col++)
                {
                    matrix[row, col] = rowAsString[col];
                }
            }

            char symbolToCheck = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    char currentSymbol = matrix[row, col];

                    if (currentSymbol==symbolToCheck)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbolToCheck} does not occur in the matrix");
        }
    }
}
