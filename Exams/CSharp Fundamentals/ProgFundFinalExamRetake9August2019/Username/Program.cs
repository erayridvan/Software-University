using System;
using System.Linq;

namespace Username
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Sign up")
            {
                string[] info = arg.Split(" ").ToArray();
                string command = info[0];

                if (command == "Case")
                {
                    string type = info[1];

                    if (type == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if (type == "upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if (command == "Reverse")
                {
                    int startIndex = int.Parse(info[1]);
                    int endIndex = int.Parse(info[2]);

                    if (startIndex >= 0 && endIndex <= username.Length && startIndex <= endIndex)
                    {
                        if (startIndex == endIndex)
                        {
                            string stringToReverse = username.Substring(startIndex, 1);

                            char[] cArray = stringToReverse.ToCharArray();
                            string reverse = String.Empty;

                            for (int i = cArray.Length - 1; i > -1; i--)
                            {
                                reverse += cArray[i];
                            }
                            Console.WriteLine(reverse);
                        }
                        else
                        {
                            int diff = endIndex - startIndex;

                            string stringToReverse = username.Substring(startIndex, diff + 1);

                            char[] cArray = stringToReverse.ToCharArray();
                            string reverse = String.Empty;

                            for (int i = cArray.Length - 1; i > -1; i--)
                            {
                                reverse += cArray[i];
                            }
                            Console.WriteLine(reverse);
                        }
                    }
                }
                else if (command == "Cut")
                {
                    string textToCheck = info[1];
                    bool isContain = username.Contains(textToCheck);

                    if (isContain)
                    {
                        username = username.Replace(textToCheck, "");
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {textToCheck}.");
                    }
                }
                else if (command == "Replace")
                {
                    char symbol = char.Parse(info[1]);

                    username = username.Replace(symbol, '*');
                    Console.WriteLine(username);
                }
                else if (command == "Check")
                {
                    char symbol = char.Parse(info[1]);

                    bool isContain = username.Contains(symbol);

                    if (isContain)
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {symbol}.");
                    }
                }
            }
        }
    }
}
