using System;
using System.Linq;
using System.Collections.Generic;

namespace FeedTheAnimals
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> nameANdLimit = new Dictionary<string, int>();
            Dictionary<string, List<string>> nameAndArea = new Dictionary<string, List<string>>();

            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Last Info")
            {
                string[] info = arg.Split(":").ToArray();
                string command = info[0];

                if (command == "Add")
                {
                    string animalName = info[1];
                    int foodLimit = int.Parse(info[2]);
                    string area = info[3];

                    AddAnimal(animalName, foodLimit, area, nameANdLimit, nameAndArea);
                }
                else if (command == "Feed")
                {
                    string animalName = info[1];
                    int food = int.Parse(info[2]);
                    string area = info[3];

                    FeedAnimal(animalName, food, area, nameANdLimit, nameAndArea);
                }
            }


            Console.WriteLine($"Animals:");

            foreach (var personInfo in nameANdLimit.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{personInfo.Key} -> {personInfo.Value}g");
            }

            Console.WriteLine($"Areas with hungry animals:");

            foreach (var place in nameAndArea.OrderByDescending(n => n.Value.Count))
            {
                if (place.Value.Count > 0)
                {
                    Console.WriteLine($"{place.Key} : {place.Value.Count}");
                }
            }
        }

        static void AddAnimal(string animalName, int foodLimit, string area, Dictionary<string, int> nameANdLimit, Dictionary<string, List<string>> nameAndArea)
        {
            if (nameANdLimit.ContainsKey(animalName))
            {
                nameANdLimit[animalName] += foodLimit;
            }
            else
            {
                nameANdLimit[animalName] = foodLimit;

                if (nameAndArea.ContainsKey(area))
                {
                    nameAndArea[area].Add(animalName);
                }
                else
                {
                    nameAndArea[area] = new List<string>();
                    nameAndArea[area].Add(animalName);
                }
            }
        }

        static void FeedAnimal(string animalName, int food, string area, Dictionary<string, int> nameANdLimit, Dictionary<string, List<string>> nameAndArea)
        {
            bool ifExist = (nameANdLimit.ContainsKey(animalName) && nameAndArea.ContainsKey(area));

            if (ifExist)
            {
                nameANdLimit[animalName] -= food;

                if (nameANdLimit[animalName] <= 0)
                {
                    Console.WriteLine($"{animalName} was successfully fed");
                    nameANdLimit.Remove(animalName);
                    if (nameAndArea[area].Contains(animalName))
                    {
                        nameAndArea[area].Remove(animalName);
                    }
                }
            }
        }
    }
}
