using System;
using System.Linq;
using System.Collections.Generic;

namespace StudentAcademy
{
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < index; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!(studentGrades.ContainsKey(name)))
                {
                    studentGrades[name] = new List<double>();
                    studentGrades[name].Add(grade);
                }
                else
                {
                    studentGrades[name].Add(grade);
                }
            }
            Dictionary<string, double> updatedInfo = new Dictionary<string, double>();

            foreach (var student in studentGrades)
            {
                string name = student.Key;
                
                updatedInfo[name] = student.Value.Sum() / student.Value.Count(); 
            }

            foreach (var student in updatedInfo.OrderByDescending(x=>x.Value))
            {
                if (student.Value>=4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value:f2}");
                }
            }
        }
    }
}
