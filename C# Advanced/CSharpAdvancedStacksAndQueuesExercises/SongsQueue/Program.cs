using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue
{
    class Program
    {
        static void Main()
        {
            string[] songs = Console.ReadLine()
                 .Split(", ")
                 .ToArray();
            Queue<string> songInQueue = new Queue<string>(songs);


            while (songInQueue.Count > 0)
            {
                string line = Console.ReadLine();
                string[] args = line.Split().ToArray();
                string command = args[0];

                if (command == "Play")
                {
                    songInQueue.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = line.Substring(4);

                    if (songInQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songInQueue.Enqueue(song);
                    }
                }
                else if (command=="Show")
                {
                    Console.WriteLine($"{string.Join(", ",songInQueue)}");
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
