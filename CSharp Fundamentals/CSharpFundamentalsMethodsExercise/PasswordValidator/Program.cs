using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            bool lenghtCheck = LenghtChecker(password);
            bool letAndDigitCheck = LetterAndDigitCheker(password);
            bool numCheck = NumberCheck(password);

            if (lenghtCheck==true && letAndDigitCheck==true & numCheck==true)
            {
                Console.WriteLine("Password is valid");
            }
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
            bool check = true;

            for (int i = 0; i < password.Length; i++)
            {
                char currentChar = password[i];

                if (!(currentChar >= 48 && currentChar <= 57)
                   && !(currentChar >= 65 && currentChar <= 90)
                    && !(currentChar >= 97 && currentChar <= 122))
                {
                    check = false;
                    break;
                }
            }

            if (check == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
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
