using System;
using System.Linq;
using System.Collections.Generic;

namespace TheVLogger
{
    class Program
    {
        static void Main()
        {
            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] inputInfo = command.Split();

                if (inputInfo[1] == "joined")
                {
                    string username = inputInfo[0];

                    if (!vloggers.ContainsKey(username))
                    {
                        vloggers.Add(username, new Dictionary<string, HashSet<string>>());
                        vloggers[username].Add("followed", new HashSet<string>());
                        vloggers[username].Add("followers", new HashSet<string>());
                    }
                }
                else if (inputInfo[1] == "followed")
                {
                    string mainUser = inputInfo[2];
                    string follower = inputInfo[0];

                    if (!vloggers.ContainsKey(mainUser) || !vloggers.ContainsKey(follower))
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    if (mainUser == follower)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    vloggers[mainUser]["followers"].Add(follower);
                    vloggers[follower]["followed"].Add(mainUser);
                }
                command = Console.ReadLine();

            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var sortedVloggers = vloggers
                .OrderByDescending(x => x.Value["followers"].Count)
                .ThenBy(x => x.Value["followed"].Count)
                .ToDictionary(k=>k.Key, v=>v.Value);

            int counter = 1;

            foreach (var (vlogger, collectionOfPeople) in sortedVloggers)
            {
                Console.WriteLine($"{counter}. {vlogger} : {collectionOfPeople["followers"].Count} followers, " +
                    $"{collectionOfPeople["followed"].Count} following");

                if (counter==1)
                {
                    foreach (var username in collectionOfPeople["followers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {username}");
                    }
                }

                counter++;
            }
            ;
        }
    }
}
