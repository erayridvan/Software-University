using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            var matrix = new string[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                string[] inputAsString = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputAsString[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command=="END")
                {
                    break;
                }

                if (command.StartsWith("swap"))
                {
                    string[] coordinates = command.Split(" ");

                    if (coordinates.Length==5)
                    {
                        int row1 = int.Parse(coordinates[1]);
                        int col1 = int.Parse(coordinates[2]);
                        int row2 = int.Parse(coordinates[3]);
                        int col2 = int.Parse(coordinates[4]);

                        if (row1 < matrix.GetLength(0) && row1 >= 0
                            && col1 < matrix.GetLength(1) && col1 >=0
                            && row2 < matrix.GetLength(0) && row2 >= 0
                            && col2 < matrix.GetLength(1) && col2 >= 0)
                        {
                            string currentValue = matrix[row1,col1];
                            matrix[row1, col1] = matrix[row2, col2];
                            matrix[row2, col2] = currentValue;

                            for (int row = 0; row < rows; row++)
                            {
                                for (int col = 0; col < cols; col++)
                                {
                                    Console.Write($"{matrix[row,col]} ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
            }
        }
    }
}
