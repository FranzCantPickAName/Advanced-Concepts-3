using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"c:\practice\europe.txt";
            FileInfo fileInfo = new FileInfo(filePath);
            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            //4 ways to create new object of StreamWriter
            //StreamWriter streamWriter = new StreamWriter(filePath);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //StreamWriter streamWriter = fileInfo.AppendText();
            //StreamWriter streamWriter = fileInfo.CreateText();

            using (StreamWriter streamWriter = fileInfo.CreateText())
            {
                streamWriter.WriteLine("Russia has an approximate population of 145,934,000.");
                streamWriter.WriteLine("Germany has an approximate population of 83,783,000.");
                streamWriter.WriteLine("United Kingdom has an approximate population of 67,886,000.");
            }
            Console.WriteLine("europe.txt created.");

            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            //3 ways to create new object of StreamReader
            //StreamReader streamReader = new StreamReader(filePath);
            //StreamReader streamReader = fileInfo.OpenText();
            //StreamReader streamReader = new StreamReader(fileStream2);

            using (StreamReader streamReader = new StreamReader(fileStream2))
            {
                Console.WriteLine("\nFile read. File content: ");

                //To read full file
                //string content_from_file = streamReader.ReadToEnd();
                //Console.WriteLine(content_from_file);

                //To read part by part (ie 10 characters at a time)
                char[] buffer = new char[10];
                int char_count;
                do
                {
                    char_count = streamReader.Read(buffer, 0, buffer.Length);
                    string s1 = new string(buffer);
                    Console.WriteLine(s1);
                }
                while (char_count > 0);
            }

            Console.ReadKey();
        }
    }
}
