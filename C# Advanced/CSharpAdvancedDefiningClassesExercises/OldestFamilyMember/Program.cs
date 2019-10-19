using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            var oldetsMember = family.GetOldersMember();

            Console.WriteLine($"{oldetsMember.Name} {oldetsMember.Age}");
        }
    }
}
