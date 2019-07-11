using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] info = text.Split(" ");
                string command = info[0];

                if (command == "exchange")
                {
                    int index = int.Parse(info[1]);

                    if (index > numbers.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeArray(index, numbers);
                    }
                }
                else if (command == "max" || command == "min")
                {
                    string type = info[1];
                    MaxAndMinIndexFinder(numbers, type, command);
                }
                else if (command == "first" || command == "last")
                {
                    int count = int.Parse(info[1]);
                    string type = info[2];

                    if (count >= numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FirstOrLastCount(numbers, type, count, command);
                    }
                }

                text = Console.ReadLine();

            }
        }

        static void ExchangeArray(int index, int[] numbers)
        {
            int[] resultArr = numbers;
            for (int i = 0; i < index+1; i++)
            {
                int firstNum = numbers[0];
                for (int k = 0; k < numbers.Length - 1; k++)
                {
                    resultArr[k] = numbers[k + 1];
                }
                resultArr[resultArr.Length - 1] = firstNum;
                numbers = resultArr;
            }
        }

        static void MaxAndMinIndexFinder(int[] numbers, string type, string command)
        {
            int maxOdd = int.MinValue;
            int minOdd = int.MaxValue;
            int maxEven = int.MinValue;
            int minEven = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum % 2 == 0)
                {
                    if (currentNum < minEven)
                    {
                        minEven = currentNum;
                    }
                    else if (currentNum > maxEven)
                    {
                        maxEven = currentNum;
                    }
                }
                else if (currentNum % 2 != 0)
                {
                    if (currentNum < minOdd)
                    {
                        minOdd = currentNum;
                    }
                    else if (currentNum > maxOdd)
                    {
                        maxOdd = currentNum;
                    }
                }
            }

            int index = 0;
            if (type == "even")
            {
                if (command == "min")
                {
                    if (minEven == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        index = Array.IndexOf(numbers, minEven);
                        Console.WriteLine(index);
                    }
                }
                else if (command == "max")
                {
                    if (maxEven <= 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        index = Array.IndexOf(numbers, maxEven);
                        Console.WriteLine(index);
                    }
                }
            }
            else if (type == "odd")
            {
                if (command == "min")
                {
                    if (minOdd == int.MaxValue)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        index = Array.IndexOf(numbers, minOdd);
                        Console.WriteLine(index);
                    }
                }
                else if (command == "max")
                {
                    if (minOdd <= 0)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        index = Array.IndexOf(numbers, maxOdd);
                        Console.WriteLine(index);
                    }
                }
            }
        }

        static void FirstOrLastCount(int[] numbers, string type, int count, string command)
        {
            int[] resultArr = new int[count-1];

            if (command=="first")
            {
                if (type == "even")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currentNum = numbers[i];

                        if (currentNum % 2 == 0)
                        {
                            resultArr[i] = currentNum;
                        }
                    }
                }
                else if (type == "odd")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int currentNum = numbers[i];

                        if (currentNum % 2 != 0)
                        {
                            resultArr[i] = currentNum;
                        }
                    }
                }
            }
            else if (command=="last")
            {
                if (type=="even")
                {
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        int currentNum = numbers[i];

                        if (currentNum % 2 == 0)
                        {
                            resultArr[i] = currentNum;
                        }
                    }
                }
                else if (type=="odd")
                {
                    for (int i = numbers.Length - 1; i >= 0; i--)
                    {
                        int currentNum = numbers[i];

                        if (currentNum % 2 != 0)
                        {
                            resultArr[i] = currentNum;
                        }
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write("[{0}] ",numbers[i]);
            }
        }
    }
}
