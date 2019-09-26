using System;
using System.Linq;

namespace SnakeMoves
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

            var matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
                counter++;

                if (counter%2==0)
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        char currentSybol = snake[0];
                        matrix[row, col] = currentSybol;
                        snake = snake.Remove(0, 1);
                        snake += currentSybol;
                    }
                }
                else
                {
                    for (int col = 0; col < cols; col++)
                    {
                        char currentSybol = snake[0];
                        matrix[row, col] = currentSybol;
                        snake = snake.Remove(0, 1);
                        snake += currentSybol;
                    }
                }
                
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
