using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            //string countriesFolderPath = @"c:\practice\countries";
            //Directory.CreateDirectory(countriesFolderPath);
            //Console.WriteLine("countries folder created.");

            //string indiaPath = countriesFolderPath + @"\India";
            //string ukPath = countriesFolderPath + @"\UK";
            //string usaPath = countriesFolderPath + @"\USA";
            //Directory.CreateDirectory(indiaPath);
            //Directory.CreateDirectory(ukPath);
            //Directory.CreateDirectory(usaPath);
            //Console.WriteLine("Sub directories created: 'India', 'UK', 'USA' ");

            //string capitalsFilePath = countriesFolderPath + @"\capitals.txt";
            //string sportsFilePath = countriesFolderPath + @"\sports.txt";
            //string populationFilePath = countriesFolderPath + @"\population.dat";

            //File.Create(capitalsFilePath).Close();
            //File.Create(sportsFilePath).Close();
            //File.Create(populationFilePath).Close();
            //Console.WriteLine("Files created: 'capitals.txt', 'sports.txt', 'population.dat' ");

            //string worldFolderPath = @"c:\practice\world";
            ////Move will throw an exception if the 'world' folder already exists
            //Directory.Move(countriesFolderPath, worldFolderPath);
            //Console.WriteLine("'countries' moved to 'world'.");

            //string[] files = Directory.GetFiles(worldFolderPath, "*.txt");
            //Console.WriteLine("\nText files: ");
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //string[] directories = Directory.GetDirectories(worldFolderPath);
            //Console.WriteLine("\nSubdirectories: ");
            //foreach (string directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Directory.Delete(worldFolderPath, true);
            //Console.WriteLine("'world' folder deleted.");

            //Now using DirectoryInfo

            string countriesFolderPath = @"c:\practice\countries";
            DirectoryInfo directoryInfo = new DirectoryInfo(countriesFolderPath);
            directoryInfo.Create();
            Console.WriteLine("countries folder created.");

            directoryInfo.CreateSubdirectory("Iran");
            directoryInfo.CreateSubdirectory("UK");
            directoryInfo.CreateSubdirectory("USA");
            Console.WriteLine("Sub directories created: 'Iran', 'UK', 'USA' ");

            new FileInfo(directoryInfo.FullName + @"\capitals.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sports.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\population.txt").Create().Close();
            Console.WriteLine("Files created: 'capitals.txt', 'sports.txt', 'population.dat' ");

            string worldFolderPath = @"c:\practice\world";
            //MoveTo will throw an exception if the 'world' folder already exists
            directoryInfo.MoveTo(worldFolderPath);
            Console.WriteLine("'countries' moved to 'world'.");

            FileInfo[] files = directoryInfo.GetFiles();
            Console.WriteLine("\nFiles: ");
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName, file.Length);
            }

            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            Console.WriteLine("\nSubdirectories: ");
            foreach (DirectoryInfo directory in directories)
            {
                Console.WriteLine(directory.FullName);
            }

            Console.WriteLine("\nAdditional DirectoryInfo: ");
            Console.WriteLine("'world' directory exists: " + worldFolderPath);
            if (directoryInfo.Exists)
            {
                Console.WriteLine("FullName: " + directoryInfo.FullName);
                Console.WriteLine("Name: " + directoryInfo.Name);
                Console.WriteLine("DirectoryName: " + directoryInfo.Parent);
                Console.WriteLine("Root: " + directoryInfo.Root);
                Console.WriteLine("LastWriteTime: " + directoryInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime: " + directoryInfo.LastAccessTime);
                Console.WriteLine("CreationTime: " + directoryInfo.CreationTime);
            }

            directoryInfo.Delete(true);
            Console.WriteLine("\n'world' folder deleted.");

            Console.ReadKey();
        }
    }
}
