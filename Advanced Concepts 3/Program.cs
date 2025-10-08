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
            string filePath = @"c:\practice\dog.txt";
            string content = "The dog is one of the common domestic animals.";

            File.WriteAllText(filePath, content);
            Console.WriteLine("File dog.txt created/modified.");

            string s = File.ReadAllText(filePath);
            Console.WriteLine("\nFile contents:");
            Console.WriteLine(s);

            string filePath2 = @"c:\practice\asia.txt";
            List<string> asia = new List<string>() { "Iran", "Iraq", "Japan" };

            File.WriteAllLines(filePath2, asia);
            Console.WriteLine("File asia.txt created/modified.");

            string[] existingContent = File.ReadAllLines(filePath2);
            foreach (string line in existingContent)
            {
                Console.WriteLine(line);
            }

                Console.ReadKey();
        }
    }
}
