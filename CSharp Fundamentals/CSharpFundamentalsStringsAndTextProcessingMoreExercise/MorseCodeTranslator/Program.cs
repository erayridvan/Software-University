using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().Split('|').Trim().ToArray();
            string output = "";
            foreach (string word in input)
            {
                    if (morseToChar.ContainsValue(word))
                    {
                        output += (morseToChar.FirstOrDefault(x => x.Value == word).Key);
                    }
            }
            Console.WriteLine(output);

        }
        static Dictionary<char, string> morseToChar = new Dictionary<char, string>()
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."}
         };
    }
}