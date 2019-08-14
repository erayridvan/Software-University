using System;
using System.Linq;
using System.Collections.Generic;

namespace String_Manipulator___Group2
{
    class Program
    {
        static void Main()
        {
            string textToChange = Console.ReadLine();
            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Done")
            {
                string[] info = arg.Split(" ").ToArray();
                string command = info[0];

                if (command == "Change")
                {
                    char symbol = char.Parse(info[1]);
                    char replacement = char.Parse(info[2]);

                    textToChange = textToChange.Replace(symbol, replacement);
                    Console.WriteLine(textToChange);
                }
                else if (command == "Includes")
                {
                    string textToCheck = info[1];

                    bool isContain = textToChange.Contains(textToCheck);
                    Console.WriteLine(isContain);
                }
                else if (command == "End")
                {
                    string textToCheck = info[1];
                    bool isContain = textToChange.EndsWith(textToCheck);
                    Console.WriteLine(isContain);
                }
                else if (command == "Uppercase")
                {
                    textToChange = textToChange.ToUpper();
                    Console.WriteLine(textToChange);
                }
                else if (command == "FindIndex")
                {
                    char symbol = char.Parse(info[1]);
                    int index = textToChange.IndexOf(symbol);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(info[1]);
                    int lenght = int.Parse(info[2]);

                    textToChange = textToChange.Substring(startIndex, lenght);
                    Console.WriteLine(textToChange);
                }
            }
        }
    }
}
