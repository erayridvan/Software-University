using System;
using System.Linq;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            Dictionary<string, string> infoUser = new Dictionary<string, string>();

            for (int i = 1; i <= index; i++)
            {
                string[] currentUser = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string command = currentUser[0];

                if (command == "register")
                {
                    string name = currentUser[1];
                    string plate = currentUser[2];

                    if (!(infoUser.ContainsKey(name)))
                    {
                        infoUser[name] = plate;
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                }
                else if (command == "unregister")
                {
                    string name = currentUser[1];
                    if (!(infoUser.ContainsKey(name)))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        infoUser.Remove(name);
                    }
                }
            }

            foreach (var user in infoUser)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
