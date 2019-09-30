using System;
using System.Linq;
using System.Collections.Generic;

namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static int playerRow;
        static int playerCol;
        static char[,] field;
        static bool isDead;
        static void Main()
        {
            isDead = false;

            int[] dimentions = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int row = dimentions[0];
            int col = dimentions[1];

            field = new char[row,col];

            InitializationField(field);
            string commands = Console.ReadLine(); // ready

            for (int i = 0; i < commands.Length; i++)
            {
                char currentCommand = commands[i];

                if (currentCommand == 'U') // ready
                {//row-1 , col
                    Move(-1,0);
                }
                else if (currentCommand == 'D')
                {//row+1 , col
                    Move(1, 0);
                }
                else if (currentCommand == 'L')
                {//row,col-1
                    Move(0, -1);
                }
                else if (currentCommand == 'R')
                {//row,col+1
                    Move(0, 1);
                }

                Spread(field);

                if (isDead)
                {
                    PrintField(field);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
            }
        }

        private static void Spread(char[,] field)
        {
            List<int> indexes = new List<int>(0);
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col]=='B')
                    {
                        indexes.Add(row);
                        indexes.Add(col);
                    }
                }
            }

            for (int i = 0; i < indexes.Count; i+=2)
            {
                int bunnyRow = indexes[i];
                int bunnyCol = indexes[i + 1];

                if (IsInside(bunnyRow,bunnyCol+1))
                {
                    if (field[bunnyRow,bunnyCol+1]=='P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow, bunnyCol+1] = 'B';
                } // ready

                if (IsInside(bunnyRow, bunnyCol - 1))
                {
                    if (field[bunnyRow, bunnyCol-1] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow, bunnyCol-1 ] = 'B';
                } // ready

                if (IsInside(bunnyRow+1, bunnyCol))
                {
                    if (field[bunnyRow+1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow+1, bunnyCol] = 'B';
                }

                if (IsInside(bunnyRow-1, bunnyCol))
                {
                    if (field[bunnyRow-1, bunnyCol] == 'P')
                    {
                        isDead = true;
                    }
                    field[bunnyRow-1, bunnyCol] = 'B';
                }
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow+row,playerCol+col))
            {
                field[playerRow, playerCol] = '.';
                Spread(field);
                PrintField(field);
                Console.WriteLine($"won: {playerRow} {playerCol}");
                Environment.Exit(0);
            }

            if (field[playerRow+row, playerCol+col]=='B')
            {
                Spread(field);
                PrintField(field);
                Console.WriteLine($"dead: {playerRow} {playerCol+col}");
                Environment.Exit(0);
            }

            field[playerRow, playerCol] = '.';

            playerRow += row;
            playerCol += col;

            field[playerRow, playerCol] = 'P';
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row,col]}");
                }
                Console.WriteLine();
            }
        }

        private static void InitializationField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] symbols = Console.ReadLine().ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = symbols[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
