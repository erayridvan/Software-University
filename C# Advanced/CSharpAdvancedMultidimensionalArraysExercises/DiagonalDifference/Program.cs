    using System;

    namespace DiagonalDifference
    {
        class Program
        {
            static void Main()
            {
                int n = int.Parse(Console.ReadLine());
                var matrix = new int[n,n];  

                for (int i = 0; i < n; i++)
                {
                    string[] rowAsString = Console.ReadLine().Split();
                    for (int k = 0; k < rowAsString.Length; k++)
                    {
                        matrix[i,k] = int.Parse(rowAsString[k]);
                    }
                }

                int primaryDiagonal = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    primaryDiagonal += matrix[i, i];
                }

                int secondaryDiagonal = 0;

                for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
                {

                        secondaryDiagonal += matrix[i, Math.Abs(n-1-i)];
                }

                int absDiff = Math.Abs(primaryDiagonal - secondaryDiagonal);

                Console.WriteLine(absDiff);
            }
        }
    }
