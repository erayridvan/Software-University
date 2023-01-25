using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main()
        {
            var fileByExtension = new Dictionary<string, Dictionary<string, long>>();

            DirectoryInfo destination = new DirectoryInfo("DirectoryTraversalDemo");

            var files = destination.GetFiles();

            foreach (var file in files)
            {
                var extension = file.Extension;
                if (!fileByExtension.ContainsKey(extension))
                {
                    fileByExtension.Add(extension, new Dictionary<string, long>());
                }
                fileByExtension[extension].Add(file.Name, file.Length);
            }
            
            var sortedDictionary = fileByExtension
                .OrderByDescending(x=>x.Value.Count)
                .ThenBy(e=>e.Key)
                .ToDictionary(x=>x.Key,x=>x.Value);

            StreamWriter writer = new StreamWriter("report.txt");
            using (writer)
            {
                foreach (var item in sortedDictionary)
                {
                    foreach (var fil in item.Value)
                    {
                        {
                            writer.WriteLine(item.Key);
                            writer.WriteLine($"--{fil.Key} - {fil.Value}");
                        }
                    }
                }
            }
        }
    }
}
