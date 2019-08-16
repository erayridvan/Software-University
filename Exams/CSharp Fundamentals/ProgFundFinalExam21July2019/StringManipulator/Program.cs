using System;
using System.Text;

namespace StringManipulator
{
    class Program
    {
        static void Main()
        {
            string word = string.Empty;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" ");
                if (commands[0] == "Add")
                {
                    word += commands[1];
                }
                if (commands[0] == "Upgrade")
                {
                    char chr = char.Parse(commands[1]);
                    StringBuilder builder = new StringBuilder();

                    for (int i = 0; i < word.Length; i++)
                    {
                        builder.Append(word[i]);
                    }
                    char replacingChar = (char)(chr + 1);
                    builder.Replace(chr, replacingChar);
                    word = string.Empty;
                    word += builder;

                }
                if (commands[0] == "Print")
                {
                    Console.WriteLine(word);
                }
                if (commands[0] == "Index")
                {
                    char charr = char.Parse(commands[1]);
                    if (word.Contains(charr.ToString()))
                    {
                        string val = string.Empty;
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (word[i] == charr)
                            {
                                val = val + i.ToString() + " ";
                            }

                        }
                        Console.WriteLine(val);
                    }
                    else
                    {
                        Console.WriteLine("None");
                    }
                }
                if (commands[0] == "Remove")
                {
                    string toRemove = commands[1];
                    StringBuilder build = new StringBuilder();
                    for (int i = 0; i < word.Length; i++)
                    {
                        build.Append(word[i]);

                    }
                    if (word.Contains(toRemove))
                    {
                        build.Replace(toRemove, "");
                    }
                    word = string.Empty;
                    word += build;
                }
            }
        }
    }
}
