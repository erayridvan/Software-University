using System;
using System.Linq;
using System.Collections.Generic;

namespace Courses
{
    class Program
    {
        static void Main()
        {
           Dictionary <string, List<string>> infoCoursesStudents= new Dictionary<string, List<string>>();
            
            while (true)
            {
                string[] info = Console.ReadLine()
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (info[0]=="end")
                {
                    break;
                }

                string courseName = info[0];
                string studentName = info[1];
                if (!(infoCoursesStudents.ContainsKey(courseName)))
                {
                    infoCoursesStudents[courseName] = new List<string>();
                    infoCoursesStudents[courseName].Add(studentName);
                }
                else
                {
                    infoCoursesStudents[courseName].Add(studentName);
                }
            }

            
            foreach (var item in infoCoursesStudents.OrderByDescending(x=>x.Value.Count))
            {
                string currentCourse = item.Key;
                Console.WriteLine($"{currentCourse.Trim()}: {infoCoursesStudents[item.Key].Count}");
                foreach (var name in item.Value.OrderBy(n=>n))
                {
                    Console.Write($"--{name}");
                    Console.WriteLine();
                }
            }
        }
    }
}
