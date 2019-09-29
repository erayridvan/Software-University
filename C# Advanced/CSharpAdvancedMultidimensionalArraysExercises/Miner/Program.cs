using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main()
        {
            int dimention = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ").ToArray();

            var gameField = new char[dimention,dimention];

            InitializationArray(gameField, dimention);
            int[] startingPoint = FindEntryPoint(gameField);
            ;
        }

        private static int[] FindEntryPoint(char[,] gameField)
        {
            int[] startingPoint = new int[2];
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    if (gameField[row,col]=='e')
                    {
                        startingPoint[0] = row;
                        startingPoint[1] = col;
                    }
                }
            }
            return startingPoint;
        }

        private static void InitializationArray(char[,] gameField, int dimention)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine()
                    .Split(" ")
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    gameField[row, col] = symbols[col];
                }
            }
        }
    }
}
