using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] comand = Console.ReadLine().Split();
            while ((comand[0]) != "end")
            {

                if (comand[0] == "exchange")
                {
                    int action = int.Parse(comand[1]);
                    if (action >= arr.Length || action < 0)
                    {
                        Console.WriteLine("Invalid index");
                        comand = Console.ReadLine().Split();

                        continue;
                    }
                    arr = MakeArrExchange(arr, action);
                }
                else if (comand[0] == "max")
                {
                    if (comand[1] == "even")
                    {
                        PrintMaxIndex(arr, comand[1]);
                    }
                    else if (comand[1] == "odd")
                    {
                        PrintMaxIndex(arr, comand[1]);
                    }
                }
                else if (comand[0] == "min")
                {
                    if (comand[1] == "even")
                    {
                        PrintMinIndex(arr, comand[1]);
                    }
                    else if (comand[1] == "odd")
                    {
                        PrintMinIndex(arr, comand[1]);
                    }
                }
                else if (comand[0] == "first")
                {
                    int count = int.Parse(comand[1]);
                    if (count > arr.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        comand = Console.ReadLine().Split();
                        continue;
                    }
                    if (comand[2] == "even")
                    {
                        PrintFirstElements(arr, comand[2], comand[1]);
                    }
                    else
                    {
                        PrintFirstElements(arr, comand[2], comand[1]);
                    }
                }
                else if (comand[0] == "last")
                {
                    int count = int.Parse(comand[1]);
                    if (count > arr.Length || count < 0)
                    {
                        Console.WriteLine("Invalid count");
                        comand = Console.ReadLine().Split();
                        continue;
                    }
                    if (comand[2] == "even")
                    {
                        PrintLastElements(arr, comand[2], comand[1]);
                    }
                    else
                    {
                        PrintLastElements(arr, comand[2], comand[1]);
                    }
                }
                comand = Console.ReadLine().Split();
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        private static void PrintLastElements(int[] arr, string comand, string count)
        {
            List<int> currentList = new List<int>();
            int currentCount = int.Parse(count);
            if (comand == "even")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                currentList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
            else
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                currentList.Reverse();
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
        }

        private static void PrintFirstElements(int[] arr, string comand, string count)
        {
            List<int> currentList = new List<int>();
            int currentCount = int.Parse(count);
            if (comand == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        currentList.Add(arr[i]);
                        currentCount--;
                        if (currentCount < 1)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine("[{0}]", string.Join(", ", currentList));
            }
        }



        private static void PrintMinIndex(int[] arr, string comand)
        {
            int index = -1;
            int min = int.MaxValue;
            if (comand == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (min >= arr[i])
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (min >= arr[i])
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }
            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void PrintMaxIndex(int[] arr, string comand)
        {
            int index = -1;
            int max = int.MinValue;
            if (comand == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (max <= arr[i])
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (max <= arr[i])
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }

            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static int[] MakeArrExchange(int[] arr, int action)
        {
            int currentNum = 0;
            for (int i = 0; i < arr.Length - 1 - action; i++)
            {
                currentNum = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j >= 1; j--)
                {

                    arr[j] = arr[j - 1];

                }
                arr[0] = currentNum;
            }

            return arr;
        }
    }
}