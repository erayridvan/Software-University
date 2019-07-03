using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberArray
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string text = Console.ReadLine();

                if (text == "End")
                {
                    break;
                }

                string[] separatedWords = text
                    .Split(" ")
                    .ToArray();

                string command = separatedWords[0];

                if (command == "Switch")
                {
                    int index = int.Parse(separatedWords[1]);

                    if (index < numbers.Length && index>=0)
                    {
                        if (numbers[index] > 0)
                        {
                            numbers[index] *= -1;
                        }
                        else
                        {
                            numbers[index] *= -1;
                        }
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(separatedWords[1]);
                    int number = int.Parse(separatedWords[2]);

                    if (index < numbers.Length && index>=0)
                    {
                        numbers[index] = number;
                    }
                }
                else if (command == "Sum")
                {
                    string secondCommand = separatedWords[1];
                    if (secondCommand == "Positive")
                    {
                        int positiveSum = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] >= 0)
                            {
                                positiveSum += numbers[i];
                            }
                        }
                        Console.WriteLine(positiveSum);
                    }
                    else if (secondCommand == "Negative")
                    {
                        int negativeSum = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] < 0)
                            {
                                negativeSum += numbers[i];
                            }
                        }
                        Console.WriteLine(negativeSum);
                    }
                    else
                    {
                        int sum = 0;
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                    }

                }
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
