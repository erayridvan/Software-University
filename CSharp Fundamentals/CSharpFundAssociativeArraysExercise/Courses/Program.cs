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
                    .Split(":")
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
        }
    }
}
