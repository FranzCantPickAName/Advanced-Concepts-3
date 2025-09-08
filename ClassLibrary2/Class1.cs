using System;

namespace ClassLibrary1
{

public class Sample : IDisposable
    {
        public Sample()
        {
            Console.WriteLine("Database connected.");
        }

        public void DisplayDataFromDatabase()
        {
            Console.WriteLine("Reading data from database.");
        }

        //Using dispose now instead of destructor
        //~Sample()
        //{
        //    Console.WriteLine("File is closed");
        //}

        public void Dispose()
        {
            Console.WriteLine("Database disconnected.");
        }
    }

}
