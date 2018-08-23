using System;
using System.IO;

namespace FileRenamer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Web Development\Beenes_Photography\images\";
            string oldFileName = "";
            string newFileName = "";

            int fileCount = Directory.GetFiles(filePath).Length;
            string[] files = new string[fileCount];

            files = Directory.GetFiles(filePath);

            for(int i = 0; i < fileCount; i++)
            {
                
                oldFileName = files[i];
                newFileName = filePath + "Nathan_Beenes_Photography" + i + ".jpg";

                Console.WriteLine(oldFileName);
                Console.WriteLine(newFileName);

                if (!File.Exists(newFileName))
                {
                    File.Move(oldFileName, newFileName);
                    Console.WriteLine("File: " + oldFileName + " -> " + newFileName + "\n");
                    File.Delete(oldFileName);
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
