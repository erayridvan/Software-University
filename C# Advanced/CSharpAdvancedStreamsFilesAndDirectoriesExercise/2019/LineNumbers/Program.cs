using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main(string[] args)
    {
        using(StreamReader reader = new StreamReader("text.txt"))
        {
            StringBuilder sb = new StringBuilder();
            int lineCounter = 1;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                int punCounter = 0;
                int letterCounter = 0;

                for (int i = 0; i < line.Length; i++)
                {
                    char symbol = line[i];
                    
                    if (symbol=='-' || symbol == '?' || symbol == '.' 
                        || symbol == '!' || symbol == '\'' || symbol == ',')
                    {
                        punCounter++;
                    }
                    else
                    {
                        if (symbol!=' ')
                        {
                            letterCounter++;
                        }
                    }
                }

                sb.AppendLine("Line "+lineCounter +": "+ line+"("+letterCounter+")" + "(" + punCounter + ")");

                lineCounter++;
            }

            File.WriteAllText("output.txt", sb.ToString());
        }
    }
}