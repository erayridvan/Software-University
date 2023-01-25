using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("words.txt");
            var readerOne = new StreamReader("text.txt");
            var writer = new StreamWriter("actualResults.txt");
            var pattern = @"[a-zA-Z']+";

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (writer)
            {
                using (readerOne)
                {
                    while (!reader.EndOfStream)
                    {
                        string word = reader.ReadLine();

                        if (!wordCount.ContainsKey(word))
                        {
                            wordCount.Add(word, 0);
                        }
                    }

                    reader.Close();

                    while (!readerOne.EndOfStream)
                    {
                        var line = readerOne.ReadLine();
                        var matches = Regex.Matches(line, pattern).ToArray();


                        foreach (var item in matches)
                        {
                            if (wordCount.ContainsKey(item.ToString().ToLower()))
                            {
                                wordCount[item.ToString().ToLower()]++;
                            }
                        }
                    }
                    
                    var sortedDictionary = wordCount.OrderByDescending(x => x.Value);

                    foreach (var item in sortedDictionary)
                    {
                        writer.WriteLine($"{item.Key}-{item.Value}");
                    }
                }
            }
        }
    }
}
