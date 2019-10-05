using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main()
        {
            string sourcePath = "copyMe.png";
            string resultPath = "result.png";

            using (var source = new FileStream(sourcePath, FileMode.Open))
            {
                using (var result = new FileStream(resultPath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        result.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
