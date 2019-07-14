using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(" ")
                .ToArray();

            string firstWord = words[0];
            string secondWord = words[1];
            int totalSum = 0;

            if (firstWord.Length==secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    char symbolOne = firstWord[i];
                    char symbolTwo = secondWord[i];

                    totalSum += (symbolOne * symbolTwo);
                }
            }
            else if (firstWord.Length>secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    char symbolOne = firstWord[i];
                    if (i<secondWord.Length)
                    {
                        char symbolTwo = secondWord[i];
                        totalSum += (symbolOne * symbolTwo);
                    }
                    else
                    {
                        totalSum += symbolOne;
                    }
                }
            }
            else if (secondWord.Length>firstWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    char symbolOne = secondWord[i];
                    if (i < firstWord.Length)
                    {
                        char symbolTwo = firstWord[i];
                        totalSum += (symbolOne * symbolTwo);
                    }
                    else
                    {
                        totalSum += symbolOne;
                    }
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}
