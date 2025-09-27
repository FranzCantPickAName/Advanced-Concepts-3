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
            Customer customer = new Customer();

            //Using all fields
            //(int customerID, string customerName, string email) = customer.GetCustomerDetails();

            //Console.WriteLine(customerID);
            //Console.WriteLine(customerName);
            //Console.WriteLine(email);

            //Skipping a field (customerName)
            (int customerID, _, string email) = customer.GetCustomerDetails();

            Console.WriteLine(customerID);
            Console.WriteLine(email);

            Console.ReadKey();
        }
    }
}
