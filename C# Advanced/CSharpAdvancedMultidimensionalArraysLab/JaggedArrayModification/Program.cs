using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] colNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                jagged[row] = colNumbers;
            }


            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                var parts = command.Split(" ");
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row < 0 || row > jagged.Length - 1)
                {
                    Console.WriteLine("Invalid coordinate");
                    continue;
                }

                if (col < 0 || col > jagged[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinate");
                    continue;
                }

                if (command.StartsWith("Add "))
                {
                    jagged[row][col] += value;
                }
                else if (command.StartsWith("Subtract "))
                {
                    jagged[row][col] -= value;
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int k = 0; k < jagged[i].Length; k++)
                {
                    Console.Write(jagged[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
