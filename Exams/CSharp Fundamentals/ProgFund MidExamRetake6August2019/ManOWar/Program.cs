using System;
using System.Linq;
using System.Collections.Generic;

namespace ManOWar
{
    class Program
    {
        static void Main()
        {
            List<int> pirateShip = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            List<int> warship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());
            bool isSunked = false;

            while (true)
            {
                string args = Console.ReadLine();

                if (args == "Retire")
                {
                    break;
                }

                string[] info = args.Split(" ").ToArray();
                string command = info[0];

                if (command == "Fire")
                {
                    int index = int.Parse(info[1]);
                    int damage = int.Parse(info[2]);

                    if (index >= 0 && index < warship.Count)
                    {
                        warship[index] -= damage;

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isSunked = true;
                            break;
                        }
                    }
                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(info[1]);
                    int endIndex = int.Parse(info[2]);
                    int damage = int.Parse(info[3]);

                    if (startIndex >= 0 && endIndex >= 0 && startIndex < pirateShip.Count && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isSunked = true;
                                break;
                            }
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(info[1]);
                    int health = int.Parse(info[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int counter = 0;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        double currentShip = pirateShip[i];
                        double procent = (currentShip / maxHealth) * 100;

                        if (procent < 20)
                        {
                            counter++;
                        }
                    }

                    Console.WriteLine($"{counter} sections need repair.");
                }
            }

            if (isSunked == false)
            {
                int warshipstatus = 0;
                int pirateShipStatus = 0;

                for (int i = 0; i < warship.Count; i++)
                {
                    warshipstatus += warship[i];
                }

                for (int i = 0; i < pirateShip.Count; i++)
                {
                    pirateShipStatus += pirateShip[i];
                }

                Console.WriteLine($"Pirate ship status: {pirateShipStatus}");
                Console.WriteLine($"Warship status: {warshipstatus}");
            }
        }
    }
}
