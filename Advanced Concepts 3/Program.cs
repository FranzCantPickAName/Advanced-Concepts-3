using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            List<string> myFriends = new List<string>() { "Scott", "Allen", "James", "Jones" };

            string[] myFriendsArray = myFriends.ToArray();

            foreach (string friend in myFriendsArray)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("\nForEach method: ");
            myFriends.ForEach(friend => Console.WriteLine(friend));

            Console.ReadKey();
        }
    }
}
