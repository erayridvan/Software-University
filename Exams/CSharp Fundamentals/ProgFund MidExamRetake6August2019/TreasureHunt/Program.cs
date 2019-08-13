using System;
using System.Linq;
using System.Collections.Generic;

namespace TreasureHunt
{
    class Program
    {
        static void Main()
        {
            List<string> treasureChest = Console.ReadLine()
                .Split('|')
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Yohoho!")
                {
                    break;
                }

                string[] info = command.Split().ToArray();

                if (info[0] == "Loot")
                {
                    for (int i = 1; i < info.Length; i++)
                    {
                        if (!treasureChest.Contains(info[i]))
                        {
                            treasureChest.Insert(0, info[i]);
                        }
                    }
                }
                else if (info[0] == "Drop")
                {
                    int index = int.Parse(info[1]);

                    if (index < treasureChest.Count && index >= 0)
                    {
                        string itemToAdd = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(itemToAdd);
                    }
                }
                else if (info[0] == "Steal")
                {
                    int index = int.Parse(info[1]);
                    List<string> removedItems = new List<string>();

                    if (index < treasureChest.Count && index >= 0)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            string removedItem = treasureChest[treasureChest.Count - 1];
                            removedItems.Insert(0, removedItem);
                            treasureChest.RemoveAt(treasureChest.Count - 1);
                        }

                        Console.WriteLine(string.Join(", ", removedItems));
                    }
                    else if (index >= treasureChest.Count)
                    {
                        int count = treasureChest.Count;
                        for (int i = 0; i < count; i++)
                        {
                            string removedItem = treasureChest[treasureChest.Count - 1];
                            removedItems.Insert(0, removedItem);
                            treasureChest.RemoveAt(treasureChest.Count - 1);
                        }

                        Console.WriteLine(string.Join(", ", removedItems));
                    }
                }
            }

            if (treasureChest.Count <= 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double itemsLenght = 0;
                double listCount = treasureChest.Count;

                for (int i = 0; i < treasureChest.Count; i++)
                {
                    string currentItem = treasureChest[i];
                    itemsLenght += currentItem.Length;
                }

                double treasureGained = itemsLenght / listCount;

                Console.WriteLine($"Average treasure gain: {treasureGained:f2} pirate credits.");
            }
        }
    }
}
