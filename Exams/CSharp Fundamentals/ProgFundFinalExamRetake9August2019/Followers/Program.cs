using System;
using System.Collections.Generic;
using System.Linq;

namespace Followers
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> peshoLikes = new Dictionary<string, int>();
            Dictionary<string, int> peshoComments = new Dictionary<string, int>();

            string arg = string.Empty;

            while ((arg = Console.ReadLine()) != "Log out")
            {
                string[] info = arg.Split(":").ToArray();
                string command = info[0];

                if (command == "New follower")
                {
                    string username = info[1].Trim();

                    if (!peshoLikes.ContainsKey(username))
                    {
                        peshoComments[username] = 0;
                        peshoLikes[username] = 0;
                    }
                }
                else if (command == "Like")
                {
                    string username = info[1].Trim();
                    int countLikes = int.Parse(info[2]);

                    if (!peshoLikes.ContainsKey(username))
                    {
                        peshoComments[username] = 0;
                        peshoLikes[username] = countLikes;
                    }
                    else
                    {
                        peshoLikes[username] += countLikes;
                    }
                }
                else if (command == "Comment")
                {
                    string username = info[1].Trim();

                    if (!peshoComments.ContainsKey(username))
                    {
                        peshoLikes[username] = 0;
                        peshoComments[username] = 0;
                    }
                    peshoComments[username] += 1;

                }
                else if (command == "Blocked")
                {
                    string username = info[1].Trim();
                    if (!peshoComments.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        peshoComments.Remove(username);
                        peshoLikes.Remove(username);
                    }
                }
            }

            int count = peshoLikes.Keys.Count;

            Console.WriteLine($"{count} followers");

            foreach (var user in peshoLikes.OrderByDescending(n => n.Value).ThenBy(k => k.Key))
            {
                int totalLikesAndComment = user.Value + peshoComments[user.Key];
                Console.WriteLine($"{user.Key}: {totalLikesAndComment}");
            }
        }
    }
}
