using ClassLibrary1;
using System;
using System.IO;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\Iran.txt", filePath2 = @"c:\practice\Iran2.txt", filePath3 = @"c:\practice\another.txt";

            File.Create(filePath).Close();
            Console.WriteLine("Iran.txt created");

            bool exists = File.Exists(filePath);
            if (exists)
            {
                File.Copy(filePath, filePath2);
                Console.WriteLine("Copied Iran.txt to Iran2.txt");

                File.Move(filePath2, filePath3);
                Console.WriteLine("Moved Iran.txt to another.txt");

                File.Delete(filePath3);
                Console.WriteLine("Deleted another.txt");

            }
            else
            {
                Console.WriteLine("File not found.");
            }

                Console.ReadKey();
        }
    }
}
