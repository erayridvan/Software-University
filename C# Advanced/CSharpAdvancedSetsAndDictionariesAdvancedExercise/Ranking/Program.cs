using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] inputInfo = input.Split(":").ToArray();

                string contest = inputInfo[0];
                string password = inputInfo[0];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input!= "end of submissions")
            {
                string[] inputInfo = input.Split("=>").ToArray();

                string contestName = inputInfo[0];
                string contestPassword = inputInfo[1];
                string student = inputInfo[2];
                int points = int.Parse(inputInfo[3]);

                if (!contests.ContainsKey(contestName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (contests[contestName]!=contestPassword)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new Dictionary<string, int>());
                }

                if (!students[student].ContainsKey(contestName))
                {
                    students[student].Add(contestName, points);
                }

                if (students[student][contestName]<points)
                {
                    students[student][contestName] = points;
                }
                input = Console.ReadLine();
            }
            ;
        }
    }
}
