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
            short countryID = 1;
            string countryName = "France";
            long population = 65273511;
            string region = "Western Europe";
            string filePath = @"c:\practice\france.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(countryID);
                binaryWriter.Write(countryName);
                binaryWriter.Write(population);
                binaryWriter.Write(region);
            }

            Console.WriteLine("france.txt created.");

            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using (BinaryReader binaryReader = new BinaryReader(fileStream2))
            {
                int countryID_from_file = binaryReader.ReadInt16();
                string countryName_from_file = binaryReader.ReadString();
                long population_from_file = binaryReader.ReadInt64();
                string region_from_file = binaryReader.ReadString();

                Console.WriteLine("Country ID: " + countryID_from_file);
                Console.WriteLine("Country Name: " + countryName_from_file);
                Console.WriteLine("Country Population: " + population_from_file);
                Console.WriteLine("Country Region: " + region_from_file);
            }



            Console.ReadKey();
        }
    }
}
