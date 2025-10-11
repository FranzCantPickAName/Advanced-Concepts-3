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
            string filePath = @"c:\practice\dog.txt";
            FileInfo fileInfo = new FileInfo(filePath);

            //Different ways to create the new file: (with potential limitations)
            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath, FileMode.Create, FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            //FileStream fileStream = fileInfo.Create();
            //FileStream fileStream = fileInfo.OpenWrite();
            FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);

            string content = "The dog is one of the domestic animals.";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);

            fileStream.Write(bytes, 0, bytes.Length);
            string content2 = "other text here";
            byte[] bytes2 = Encoding.ASCII.GetBytes(content2);
            fileStream.Write(bytes2 , 0, bytes2.Length);

            fileStream.Close();
            Console.WriteLine("dog.txt created.");

            //Different ways to read the file: (with potential limitations)
            //FileStream fileStream2 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            //FileStream fileStream2 = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            //FileStream fileStream2 = File.OpenRead(filePath);
            //FileStream fileStream2 = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.Read);
            FileStream fileStream2 = fileInfo.OpenRead();

            byte[] bytes3 = new byte[fileStream2.Length];

            fileStream2.Read(bytes3, 0, bytes3.Length);

            string content3 = Encoding.ASCII.GetString(bytes3);
            Console.WriteLine("\nFile read. File contents: ");
            Console.WriteLine(content3);
            fileStream2.Close();

            Console.ReadKey();
        }
    }
}
