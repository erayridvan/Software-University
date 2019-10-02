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
            var reader = new StreamReader("C:\\Users" +
                "\\Eray\\Documents\\Github\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\WordCount\\03. Word Count\\words.txt");

            var readerOne = new StreamReader("C:\\Users" +
                "\\Eray\\Documents\\Github\\Software-University-CSharp" +
                "\\C# Advanced\\CSharpAdvancedStreamsFilesAndDirectoriesLab" +
                "\\WordCount\\03. Word Count\\text.txt");

            var writer = new StreamWriter("output.txt");

            var pattern = @"[a-zA-Z']+";

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            using (writer)
            {
                using (readerOne)
                {
                    string[] words = reader
                        .ReadLine()
                        .Split(" ")
                        .ToArray();

                    reader.Close();

                    for (int i = 0; i < words.Length; i++)
                    {
                        var currentWord = words[i];

                        if (!wordCount.ContainsKey(currentWord))
                        {
                            wordCount.Add(currentWord,0);
                        }
                    }

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
