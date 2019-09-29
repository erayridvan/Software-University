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

            var gameField = new char[dimention, dimention];

            InitializationArray(gameField, dimention);
            int[] startingPoint = FindEntryPoint(gameField);
            int totalCaol = NumberCoals(gameField);
            bool check = true;

            for (int i = 0; i < commands.Length; i++)
            {
                string currentCommand = commands[i];
                int row = startingPoint[0];
                int col = startingPoint[1];
                if (currentCommand == "up")
                {// row-1 col
                    if (row-1 >= 0 && col >= 0 && row-1 < gameField.GetLength(0) && col < gameField.GetLength(1))
                    {
                        if (gameField[row - 1,col]=='e')
                        {
                            Console.WriteLine($"Game over! ({row-1}, {col})");
                            check = false;
                            break;
                        }
                        else if (gameField[row - 1, col] == 'c')
                        {
                            gameField[row - 1, col] = '*';
                            totalCaol--;
                            if (totalCaol==0)
                            {
                                Console.WriteLine($"You collected all coals! ({row-1}, {col})");
                                check = false;
                                break;
                            }
                        }
                        startingPoint[0] -= 1;
                    }
                }
                else if (currentCommand == "down")
                {//row+1 col
                    if (row + 1 >= 0 && col >= 0 && row + 1 < gameField.GetLength(0) && col < gameField.GetLength(1))
                    {
                        if (gameField[row + 1, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row + 1}, {col})");
                            check = false;
                            break;
                        }
                        else if (gameField[row + 1, col] == 'c')
                        {
                            gameField[row + 1, col] = '*';
                            totalCaol--;
                            if (totalCaol == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({row + 1}, {col})");
                                check = false;
                                break;
                            }
                        }
                        startingPoint[0] += 1;
                    }
                }
                else if (currentCommand == "right")
                {//row col+1
                    if (row  >= 0 && col+1 >= 0 && row < gameField.GetLength(0) && col+1 < gameField.GetLength(1))
                    {
                        if (gameField[row , col+1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col+1})");
                            check = false;
                            break;
                        }
                        else if (gameField[row, col + 1] == 'c')
                        {
                            gameField[row , col+1] = '*';
                            totalCaol--;
                            if (totalCaol == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col+1})");
                                check = false;
                                break;
                            }
                        }
                        startingPoint[1] += 1;
                    }
                }
                else if (currentCommand == "left")
                {//row col-1
                    if (row  >= 0 && col -1>= 0 && row < gameField.GetLength(0) && col-1 < gameField.GetLength(1))
                    {
                        if (gameField[row , col-1] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row }, {col-1})");
                            check = false;
                            break;
                        }
                        else if (gameField[row, col - 1] == 'c')
                        {
                            gameField[row , col-1] = '*';
                            totalCaol--;
                            if (totalCaol == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({row}, {col-1})");
                                check = false;
                                break;
                            }
                        }
                        startingPoint[1] -= 1;
                    }
                }
            }

            if (check)
            {
                Console.WriteLine($"{totalCaol} coals left. ({startingPoint[0]}, {startingPoint[1]})");
            }
            ;
        }

       
        private static int NumberCoals(char[,] gameField)
        {
            int coal = 0;
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    if (gameField[row, col] == 'c')
                    {
                        coal++;
                    }
                }
            }
            return coal;
        }

        private static int[] FindEntryPoint(char[,] gameField)
        {
            int[] startingPoint = new int[2];
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int col = 0; col < gameField.GetLength(1); col++)
                {
                    if (gameField[row, col] == 's')
                    {
                        startingPoint[0] = row;
                        startingPoint[1] = col;
                        break;
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
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
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
