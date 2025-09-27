using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string str = "Universe";
            string str2 = "Universe";

            bool eq = str.Equals(str2);
            bool eq2 = str == str2;

            Console.WriteLine("Equals: " + eq);
            Console.WriteLine("==: " + eq2);

            bool sw = str.StartsWith("U");
            Console.WriteLine("Starts with U: " + sw);
            bool sw2 = str.StartsWith("e");
            Console.WriteLine("Starts with e: " + sw2);

            bool ew = str.EndsWith("e");
            bool ew2 = str.EndsWith("U");
            Console.WriteLine("Ends with e: " + ew);
            Console.WriteLine("Ends with U: " + ew2);

            bool ct = str.Contains("e");
            bool ct2 = str.Contains("t");
            Console.WriteLine("Contains e: " + ct);
            Console.WriteLine("Contains t: " + ct2);

            string name = "developer";
            Console.WriteLine("Index of e: " + name.IndexOf("e"));
            Console.WriteLine("Index of vel: " + name.IndexOf("vel"));
            Console.WriteLine("Index of gel: " + name.IndexOf("gel"));
            Console.WriteLine("Index of e (past index 2): " + name.IndexOf("e", 2));
            Console.WriteLine("Index of e (past index 4): " + name.IndexOf("e", 4));

            Console.WriteLine("Last index of e: " + name.LastIndexOf("e"));
            Console.WriteLine("Last index of vel: " + name.LastIndexOf("vel"));
            Console.WriteLine("Last index of gel: " + name.LastIndexOf("gel"));
            Console.WriteLine("Last index of e (before index 2): " + name.LastIndexOf("e", 2));
            Console.WriteLine("Last index of e (before index 4): " + name.LastIndexOf("e", 4));

            string user_input = null;
            string user_input2 = "";
            string user_input3 = " ";
            Console.WriteLine("Is null or empty (null): " + string.IsNullOrEmpty(user_input));
            Console.WriteLine("Is null or empty (\"\"): " + string.IsNullOrEmpty(user_input2));
            Console.WriteLine("Is null or empty (\" \"): " + string.IsNullOrEmpty(user_input3));

            Console.WriteLine("Is null or white space (null): " + string.IsNullOrWhiteSpace(user_input));
            Console.WriteLine("Is null or white space (\"\"): " + string.IsNullOrWhiteSpace(user_input2));
            Console.WriteLine("Is null or white space (\" \"): " + string.IsNullOrWhiteSpace(user_input3));




            Console.ReadKey();
        }
    }
}
