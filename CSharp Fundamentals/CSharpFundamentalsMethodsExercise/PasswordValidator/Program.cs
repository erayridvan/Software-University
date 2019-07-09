using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            LenghtChecker(password);
            LetterAndDigitCheker(password);
            NumberCheck(password);

        }

        static bool LenghtChecker(string password)
        {
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool LetterAndDigitCheker(string password)
        {
            bool check = false;

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (!(currentChar >= 48 && currentChar <= 57)
                   && !(currentChar >= 65 && currentChar <= 90)
                    && !(currentChar >= 97 && currentChar <= 122))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    check = false;
                    return false;
                    break;
                }
                check = true;
            }

            if (check=true)
            {
                return true;
            }
        }

        static bool NumberCheck(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];
                if (currentChar >= 48 && currentChar <= 57)
                {
                    counter++;
                }
            }

            if (counter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
