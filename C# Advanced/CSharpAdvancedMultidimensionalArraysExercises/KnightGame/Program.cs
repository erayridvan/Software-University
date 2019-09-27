using System;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main()
        {
            int dimentions = int.Parse(Console.ReadLine());

            var gameBoard = new string[dimentions, dimentions];

            InitializationGameBoard(gameBoard, dimentions);

            int knightCounter = 0;
            if (dimentions > 2)
            {
                Console.WriteLine(KnightRemoving(gameBoard, dimentions, knightCounter));
            }
            else
            {
                Console.WriteLine(knightCounter);
            }
        }

        private static int KnightRemoving(string[,] gameBoard, int dimentions, int knightCounter)
        {
            for (int row = 0; row < dimentions; row++)
            {
                for (int col = 0; col < dimentions; col++)
                {
                    if (gameBoard[row, col] == "K")
                    {
                        if (col + 1 < gameBoard.GetLength(1) && row + 2 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row + 2, col + 1] == "K")
                            {
                                gameBoard[row + 2, col + 1] = "0";
                                knightCounter++;
                            }
                        }

                        if (col + 2 < gameBoard.GetLength(1) && row + 1 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row + 1, col + 2] == "K")
                            {
                                gameBoard[row + 1, col + 2] = "0";
                                knightCounter++;
                            }
                        }

                        if (col - 1 >= 0 && col - 1 < gameBoard.GetLength(1) && row + 2 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row + 2, col - 1] == "K")
                            {
                                gameBoard[row + 2, col - 1] = "0";
                                knightCounter++;
                            }
                        }

                        if (col - 2 >= 0 && col - 2 < gameBoard.GetLength(1) && row + 1 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row + 1, col - 2] == "K")
                            {
                                gameBoard[row + 1, col - 2] = "0";
                                knightCounter++;
                            }
                        }



                        if (col - 1 >= 0 && row - 2 >= 0 && col - 1 < gameBoard.GetLength(1) && row - 2 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row - 2, col - 1] == "K")
                            {
                                gameBoard[row - 2, col - 1] = "0";
                                knightCounter++;
                            }
                        }

                        if (row - 2 >= 0 && col + 1 < gameBoard.GetLength(1) && row - 2 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row - 2, col + 1] == "K")
                            {
                                gameBoard[row - 2, col + 1] = "0";
                                knightCounter++;
                            }
                        }

                        if (col - 2 >= 0 && row - 1 >= 0 && col - 2 < gameBoard.GetLength(1) && row - 1 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row - 1, col - 2] == "K")
                            {
                                gameBoard[row - 1, col - 2] = "0";
                                knightCounter++;
                            }
                        }

                        if (row - 1 >= 0 && col + 2 < gameBoard.GetLength(1) && row - 1 < gameBoard.GetLength(0))
                        {
                            if (gameBoard[row - 1, col + 2] == "K")
                            {
                                gameBoard[row - 1, col + 2] = "0";
                                knightCounter++;
                            }
                        }
                    }
                }
            }

            return knightCounter;
        }

        private static void InitializationGameBoard(string[,] gameBoard, int dimentions)
        {
            for (int row = 0; row < dimentions; row++)
            {
                string input = Console.ReadLine().Trim();
                string[] arrSymbols = input.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < dimentions; col++)
                {
                    gameBoard[row, col] = arrSymbols[col];
                }
            }
        }
    }
}
