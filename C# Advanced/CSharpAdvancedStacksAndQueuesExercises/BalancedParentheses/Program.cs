using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, char> pairsBrackets = new Dictionary<char, char>();
            pairsBrackets.Add('(', ')');
            pairsBrackets.Add('{', '}');
            pairsBrackets.Add('[', ']');

            string expression = Console.ReadLine();

            if (expression.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            Stack<char> openingBrackets = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                char currentSymbol = expression[i];

                if (currentSymbol=='(' || currentSymbol == '['|| currentSymbol == '{')
                {
                    openingBrackets.Push(currentSymbol);
                }
                else if (openingBrackets.Count==0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    char openBracket = openingBrackets.Pop();
                    char expectedBracket = pairsBrackets[openBracket];

                    if (currentSymbol!=expectedBracket)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
                
            if (openingBrackets.Count==0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
