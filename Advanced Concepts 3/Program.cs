using ClassLibrary1;
using System;
using System.IO;
namespace IndexOutOfRangeExceptionExample
{
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }
    class Program
    {

        static string logFile = "exception.log";

        static void Main()
        {

            if (File.Exists(logFile))
                File.Delete(logFile);

            HandleException(() => int.Parse("abc"), "FormatException");
            HandleException(() =>
            {
                int[] arr = { 1, 2, 3 };
                Console.WriteLine(arr[5]);
            },
            "IndexOutOfRangeException");
            HandleException(() =>
            {
                string str = null;
                Console.WriteLine(str.Length);
            },
            "NullReferenceException");
            HandleException(() =>
            {
                string str = null;
                Console.WriteLine(str.ToUpper());
            },
            "ArgumentNullException");
            HandleException(() =>
            {
                try
                {
                    int.Parse("xyz");

                }
                catch (FormatException ex)
                {
                    throw new InvalidOperationException("Invalid operation", ex);
                }
            },
            "Inner Exception Example");
            HandleException(() =>
            {
                string text = "Hello";
                Console.WriteLine(text.Substring(10));
            },
            "ArgumentOutOfRangeException");
            HandleException(() =>
            {
                string path = "";
                System.IO.Path.GetFullPath(path);
            },
            "ArgumentException");
            HandleException(() =>
            {
                var enumerator = new int[] { 1, 2, 3 }.GetEnumerator();
                enumerator.Reset();
            },
            "InvalidOperationException");
            HandleException(() =>
            {
                throw new MyCustomException("This is a custom exception!");
            },
            "CustomException");

            Console.WriteLine("All exceptions have been logged to exception.log");

            Console.ReadKey();
        }

        static void HandleException(Action action, string exceptionName)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                string message = $"{exceptionName}: {ex.Message}";
                Console.WriteLine(message);

                if (ex.InnerException != null)
                {
                    message += $"\nInner Exception: {ex.InnerException.Message}";
                }
                LogToFile(message);
            }
        }


        static void LogToFile(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}


