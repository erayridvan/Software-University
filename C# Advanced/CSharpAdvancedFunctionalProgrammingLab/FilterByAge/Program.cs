using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{

    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }
    }
    class Program
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] parts = line.Split(", ");
                string name = parts[0];
                int age = int.Parse(parts[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            string condotionString = Console.ReadLine();
            int conditionParameter = int.Parse(Console.ReadLine());

            Func<Person, bool> predicate;

            if (condotionString=="older")
            {
                predicate = p => p.Age >= conditionParameter;
            }
            else if (condotionString == "younger")
            {
                predicate = p => p.Age < conditionParameter;
            }
            else
            {
                predicate = p => true;
            }

            var newPeople = people.Where(predicate);

            string format = Console.ReadLine();

            foreach (var person in newPeople)
            {
                if (format=="age")
                {
                    Console.WriteLine($"{person.Age}");
                }
                else if (format == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
            }
        }
    }
}
