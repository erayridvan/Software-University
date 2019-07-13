using System;
using System.Linq;
using System.Collections.Generic;

namespace TasksPlanner
{
    class Program
    {
        static void Main()
        {
            List<int> tasks = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            while (text != "End")
            {
                string[] info = text.Split(" ");
                string command = info[0];

                if (command == "Complete")
                {
                    int index = int.Parse(info[1]);

                    if (index < tasks.Count && index>=0)
                    {
                        Complete(tasks, index);
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(info[1]);
                    int time = int.Parse(info[2]);

                    if (index < tasks.Count && index >= 0)
                    {
                        Change(tasks, index, time);
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(info[1]);

                    if (index < tasks.Count && index >= 0)
                    {
                        Drop(tasks, index);
                    }
                }
                else if (command == "Count")
                {
                    string type = info[1];
                    Count(tasks, type);
                }

                text = Console.ReadLine();
            }

            foreach (var time in tasks)
            {
                if (time>0)
                {
                    Console.Write($"{time} ");
                }
            }

            Console.WriteLine();

        }

        static void Complete(List<int> tasks, int index)
        {
            tasks[index] = 0;
        }

        static void Change(List<int> tasks, int index, int time)
        {
            tasks[index] = time;
        }

        static void Drop(List<int> tasks, int index)
        {
            tasks[index] = -1;
        }

        static void Count(List<int> tasks, string type)
        {
            int count = 0;

            if (type == "Completed")
            {
                foreach (var time in tasks)
                {
                    if (time==0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
            else if (type == "Incomplete")
            {
                foreach (var time in tasks)
                {
                    if (time>0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
            else if (type == "Dropped")
            {
                foreach (var time in tasks)
                {
                    if (time<0)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
