using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Submit
    {
        public List<string> lang { get; set; }
        public List<int> grade { get; set; }

        public Submit()
        {
            this.lang = new List<string>();
            this.grade = new List<int>();
        }
    }

    class Program
    {
        static void Main()
        {
            var examResults = new Dictionary<string, Submit>();
            var bannedList = new List<string>();

            string input;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] command = input.Split("-").ToArray();
                if (command[1] != "banned")
                {
                    string name = command[0];
                    string language = command[1];
                    int grade = int.Parse(command[2]);
                    if (examResults.ContainsKey(name)) StoreNewSubmission(examResults, name, language, grade);
                    else
                    {
                        examResults.Add(name, new Submit());
                        StoreNewSubmission(examResults, name, language, grade);
                    }
                }
                else
                {
                    string name = command[0];
                    bannedList.Add(name);
                }
            }
            Console.WriteLine("Results:");
            var users = new Dictionary<string, int>();
            LoadUsersAndGrades(examResults, users);
            var sorted = users.OrderByDescending(k => k.Value).ThenBy(p => p.Key);
            foreach (var user in sorted)
            {
                if (!bannedList.Contains(user.Key))
                    Console.WriteLine($"{user.Key} | {user.Value}");
            }
            Console.WriteLine("Submissions:");
            var submission = new Dictionary<string, int>();
            LoadLanguagesAndTries(examResults, submission);
            var sortSubmisson = submission.OrderByDescending(k => k.Value).ThenBy(p => p.Key);
            foreach (var lang in sortSubmisson)
                Console.WriteLine($"{lang.Key} - {lang.Value}");
        }

        static void StoreNewSubmission(Dictionary<string, Submit> list, string name, string language, int grade)
        {
            list[name].lang.Add(language);
            list[name].grade.Add(grade);
        }

        static void LoadLanguagesAndTries(Dictionary<string, Submit> list, Dictionary<string, int> oper)
        {
            foreach (var user in list)
            {
                for (int i = 0; i < user.Value.lang.Count; i++)
                {
                    if (!oper.ContainsKey(user.Value.lang[i])) oper.Add(user.Value.lang[i], 1);
                    else oper[user.Value.lang[i]]++;
                }
            }
        }

        static void LoadUsersAndGrades(Dictionary<string, Submit> list, Dictionary<string, int> oper)
        {
            foreach (var user in list)
            {
                int maxGrage = 0;
                for (int i = 0; i < user.Value.lang.Count; i++)
                {
                    if (user.Value.grade[i] > maxGrage) maxGrage = user.Value.grade[i];
                }
                oper.Add(user.Key, maxGrage);
            }
        }
    }
}