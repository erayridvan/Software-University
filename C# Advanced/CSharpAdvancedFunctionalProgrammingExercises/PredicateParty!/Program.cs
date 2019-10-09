using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main()
        {
            Func<string, int, bool> lenghtFunc = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFunc = (name, pattern) => name.StartsWith(pattern);
            Func<string, string, bool> endsWithFunc = (name, pattern) => name.EndsWith(pattern);

            List<string> names = Console.ReadLine()
                .Split(" ")
                .ToList();

            string command = Console.ReadLine();

            while (command != "Party!")
            {
                string[] commandInfo = command.Split(" ");
                string action = commandInfo[0];
                string condition = commandInfo[1];
                string param = commandInfo[2];

                if (action == "Double")
                {
                    if (condition == "Length")
                    {
                        int lenght = int.Parse(param);

                        var tempNames = names.Where(name => lenghtFunc(name, lenght)).ToList();

                        MyAddRange(names, tempNames);
                    }
                    else if (condition == "StartsWith")
                    {
                        var tempNames = names.Where(name => startsWithFunc(name, param)).ToList();

                        MyAddRange(names, tempNames);
                    }
                    else if (condition == "EndsWith")
                    {
                        var tempNames = names.Where(name => endsWithFunc(name, param)).ToList();

                        MyAddRange(names, tempNames);
                    }
                }
                else if (command != "Remove")
                {
                    if (condition == "Length")
                    {
                        int lenght = int.Parse(param);

                        names = names.Where(name => !lenghtFunc(name, lenght)).ToList();
                    }
                    else if (condition == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFunc(name, param)).ToList();
                    }
                    else if (condition == "EndsWith")
                    {
                        names = names.Where(name => !endsWithFunc(name, param)).ToList();
                    }
                }

                command = Console.ReadLine();
            }

            if (names.Count>0)
            {
                Console.WriteLine($"{string.Join(", ",names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void MyAddRange(List<string> names, List<string> tempNames)
        {
            foreach (var currentName in tempNames)
            {
                int index = names.IndexOf(currentName);
                names.Insert(index, currentName);
            }
        }
    }
}
