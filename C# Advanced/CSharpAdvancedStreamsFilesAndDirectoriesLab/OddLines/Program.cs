using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader($"input.txt"))
            {
                int counter = 1;

                using (var writer = new StreamWriter($"output.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                    }
                }
            }
        }
    }
}

