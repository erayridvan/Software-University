using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterShopping
{
    class Program
    {
        static void Main()
        {
            List<string> shops = Console.ReadLine()
                 .Split(" ")
                 .ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                string[] separatedInput = input
                    .Split(" ")
                    .ToArray();
                string command = separatedInput[0];

                if (command== "Include")
                {
                    string shop = separatedInput[1];
                    shops.Add(shop);
                }
                else if (command== "Visit")
                {
                    string place = separatedInput[1];
                    int numberOfShops = int.Parse(separatedInput[2]);

                    if (!(numberOfShops>shops.Count))
                    {
                        if (place=="first")
                        {
                            for (int j = 0; j < numberOfShops; j++)
                            {
                                shops.Remove(shops[0]);
                            }
                        }
                        else if (place=="last")
                        {
                            int index = shops.Count - 1 - numberOfShops;
                            for (int k = shops.Count - 1; k > index; k--)
                            {
                                shops.Remove(shops[shops.Count-1]);
                            }
                        }
                    }
                }
                else if (command== "Prefer")
                {
                    int indexOne = int.Parse(separatedInput[1]);
                    int indexTwo = int.Parse(separatedInput[2]);
                    if (indexOne<shops.Count && indexTwo<shops.Count)
                    {
                        string newShop = shops[indexOne];
                        shops[indexOne] = shops[indexTwo];
                        shops[indexTwo] = newShop;
                    }
                }
                else if (command== "Place")
                {
                    string newShop = separatedInput[1];
                    int index = int.Parse(separatedInput[2]);

                    if (index<shops.Count)
                    {
                        index += 1;
                        shops.Insert(index, newShop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
