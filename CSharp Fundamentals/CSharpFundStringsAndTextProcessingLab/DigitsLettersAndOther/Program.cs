using System;
using System.Linq;

namespace DigitsLettersAndOther
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            string digits = "";
            string letters = "";
            string others = "";
        
            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                bool isLetter = char.IsLetter(currentSymbol);
                bool isDigit = char.IsDigit(currentSymbol);

                if (isLetter == true)
                {
                    letters += currentSymbol;
                }
                else if (isDigit==true)
                {
                    digits += currentSymbol;
                }
                else
                {
                    others += currentSymbol;
                }
            }


            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
