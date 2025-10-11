using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\japan.txt";
            string destPath = @"c:\practice\another.txt";
            string destPath2 = @"c:\practice\somethingelse.txt";

            FileInfo fileInfo = new FileInfo(filePath);

            //fileInfo.Create().Close();
            //Console.WriteLine("japan.txt created");

            Console.WriteLine("japan.txt exists: " + fileInfo.Exists);
            if (fileInfo.Exists)
            {
                Console.WriteLine("FullName: " + fileInfo.FullName);
                Console.WriteLine("Name: " + fileInfo.Name);
                Console.WriteLine("DirectoryName: " + fileInfo.DirectoryName);
                Console.WriteLine("Extension: " + fileInfo.Extension);
                Console.WriteLine("Length: " + fileInfo.Length + " bytes");
                Console.WriteLine("LastWriteTime: " + fileInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + fileInfo.LastAccessTime);
                Console.WriteLine("CreationTime: " + fileInfo.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found.");
            }

            Console.WriteLine();

            FileInfo fileInfo2 = fileInfo.CopyTo(destPath, true);
            Console.WriteLine(fileInfo2.Name + " created.");

            fileInfo2.MoveTo(destPath2);
            Console.WriteLine(fileInfo2.Name + " moved.");
            
            fileInfo2.Delete();
            Console.WriteLine(fileInfo2.Name + " deleted.");

                Console.ReadKey();
        }
    }
}
