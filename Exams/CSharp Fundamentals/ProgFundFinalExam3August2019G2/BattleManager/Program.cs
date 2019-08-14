using System;
using System.Linq;
using System.Collections.Generic;

namespace BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> personHealth = new Dictionary<string, int>();
            Dictionary<string, int> personEnergy = new Dictionary<string, int>();

            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Results")
            {
                string[] info = arg.Split(":").ToArray();
                string command = info[0];

                if (command == "Add")
                {
                    string personName = info[1];
                    int health = int.Parse(info[2]);
                    int energy = int.Parse(info[3]);

                    AddPerson(personName, health, energy, personHealth, personEnergy);
                }
                else if (command == "Attack")
                {
                    string attackerName = info[1];
                    string defenderName = info[2];
                    int damage = int.Parse(info[3]);

                    AttackCalculation(attackerName, defenderName, damage, personHealth, personEnergy);
                }
                else if (command == "Delete")
                {
                    string nameToDelete = info[1];

                    Delete(nameToDelete, personHealth, personEnergy);
                }
            }

            int peopleCount = personHealth.Count;

            Console.WriteLine($"People count: {peopleCount}");

            foreach (var personInfo in personHealth.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{personInfo.Key} - {personInfo.Value} - {personEnergy[personInfo.Key]}");
            }
        }

        static void AddPerson(string personName, int health, int energy, Dictionary<string, int> personHealth, Dictionary<string, int> personEnergy)
        {
            if (personHealth.ContainsKey(personName))
            {
                personHealth[personName] += health;
            }
            else
            {
                personHealth[personName] = health;
                personEnergy[personName] = energy;
            }
        }

        static void AttackCalculation(string attackerName, string defenderName, int damage, Dictionary<string, int> personHealth, Dictionary<string, int> personEnergy)
        {
            bool ifExist = (personHealth.ContainsKey(attackerName) && personHealth.ContainsKey(defenderName));

            if (ifExist)
            {
                personHealth[defenderName] -= damage;

                if (personHealth[defenderName] <= 0)
                {
                    Console.WriteLine($"{defenderName} was disqualified!");
                    personHealth.Remove(defenderName);
                    personEnergy.Remove(defenderName);
                }

                personEnergy[attackerName] -= 1;

                if (personEnergy[attackerName] == 0)
                {
                    Console.WriteLine($"{attackerName} was disqualified!");
                    personHealth.Remove(attackerName);
                    personEnergy.Remove(attackerName);
                }
            }
        }

        static void Delete(string nameToDelete, Dictionary<string, int> personHealth, Dictionary<string, int> personEnergy)
        {
            if (nameToDelete == "All")
            {
                personHealth.Clear();
                personEnergy.Clear();
            }
            else if (personHealth.ContainsKey(nameToDelete))
            {
                personHealth.Remove(nameToDelete);
                personEnergy.Remove(nameToDelete);
            }
        }
    }
}
