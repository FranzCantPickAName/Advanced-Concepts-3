using ClassLibrary1;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.Script.Serialization;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Customer customer = new Customer() { CustomerID = 1, CustomerName = "Nancy", age = 20 };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string filePath = @"c:\practice\customer.txt";
            StreamWriter streamWriter = new StreamWriter(filePath);

            string json = javaScriptSerializer.Serialize(customer);
            streamWriter.WriteLine(json);
            streamWriter.Close();
            Console.WriteLine(json);
            Console.WriteLine("File serialized.");

            StreamReader streamReader = new StreamReader(filePath);
            Customer customer_from_file = javaScriptSerializer.Deserialize(streamReader.ReadToEnd(), typeof(Customer)) as Customer;

            Console.WriteLine("\nData after deserialization: ");
            Console.WriteLine("Customer ID: " + customer_from_file.CustomerID);
            Console.WriteLine("Customer Name: " + customer_from_file.CustomerName);
            Console.WriteLine("Customer Age: " + customer_from_file.age);

            Console.ReadKey();
        }
    }
}
