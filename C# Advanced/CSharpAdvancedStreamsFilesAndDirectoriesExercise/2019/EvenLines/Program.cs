using System;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineCounter = 0;
            var symbolsToReplace = new[] { "-", ",", ".", "!", "?" };
            var sb = new StringBuilder();

            using (var streamReader = new StreamReader(@"text.txt"))
            {
                while (!streamReader.EndOfStream)
                {
                    string line = streamReader.ReadLine();

                    if (lineCounter%2==0)
                    {
                        var words = line.Split();

                        for (int i = 0; i < words.Length; i++)
                        {
                            var currentWord = words[i];

                            foreach (var symbol in symbolsToReplace)
                            {
                                currentWord = currentWord.Replace(symbol, "@");
                            }

                            words[i] = currentWord;
                        }

                        var result = string.Join(" ", words.Reverse());

                        sb.AppendLine(result);
                    }
                    lineCounter++;
                }

                File.WriteAllText("output.txt", sb.ToString());
            }
        }
    }
}
