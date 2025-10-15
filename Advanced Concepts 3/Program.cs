using ClassLibrary1;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Country country = new Country() { CountryID = 1, CountryName = "Russia", Population = 145934000, Region = "Eastern Europe" };

            string filePath = @"c:\practice\russia.txt";
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, country);
            fileStream.Close();
            Console.WriteLine("File serialized.");

            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            Country country_from_file = (Country)binaryFormatter.Deserialize(fileStream2);
            Console.WriteLine("\nData after deserialization: ");
            Console.WriteLine("Country ID: " + country_from_file.CountryID);
            Console.WriteLine("Country Name: " + country_from_file.CountryName);
            Console.WriteLine("Country Population: " + country_from_file.Population);
            Console.WriteLine("Country Region: " + country_from_file.Region);

            Console.ReadKey();
        }
    }
}
