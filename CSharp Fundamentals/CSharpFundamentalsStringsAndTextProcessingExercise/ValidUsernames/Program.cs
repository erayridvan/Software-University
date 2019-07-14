using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main()
        {
            List<string> usernames = Console.ReadLine()
                .Split(new string[] {", " },StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> validUsername = new List<string>();

            foreach (var username in usernames)
            {
                if (username.Length>=3 && username.Length<=16)
                {
                    bool usernameValidator = UsernameValidator(username);
                    if (usernameValidator==true)
                    {
                        validUsername.Add(username);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsername));
        }

        static bool UsernameValidator(string username)
        {
            for (int i = 0; i < username.Length; i++)
            {
                char currentSymbol = username[i];

                if (char.IsLetterOrDigit(currentSymbol) 
                    ||currentSymbol=='-'
                    || currentSymbol == '_')
                {
                    continue;
                }
                else
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}
