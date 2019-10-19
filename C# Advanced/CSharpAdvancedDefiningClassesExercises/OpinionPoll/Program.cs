using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            people = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
