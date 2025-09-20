using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            string choice;
            do
            {
                Console.Write("Enter Product ID: ");
                int pID = int.Parse(Console.ReadLine());
                Console.Write("Enter Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Enter Product Price: ");
                double unitPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter Date of Manufacture (YYYY-MM-DD) : ");
                DateTime dateOfManufacture = DateTime.Parse(Console.ReadLine());

                Product product = new Product()
                { ProductID = pID, ProductName = pName, ProductPrice = unitPrice, DateOfManufacture = dateOfManufacture };

                products.Add(product);

                Console.WriteLine("Product Added.\n");
                Console.WriteLine("Do you want to continue to next product? (Yes/No)");
                choice = Console.ReadLine();
            }
            while (choice != "No" && choice != "no" && choice != "n" && choice != "N");

            Console.WriteLine("\nProducts:");
            foreach (Product item in products)
            {
                Console.WriteLine(item.ProductID + ", " + item.ProductName + ", " + item.ProductPrice + ", " + item.DateOfManufacture.ToShortDateString());
            }

            Console.ReadKey();
        }
    }
}
