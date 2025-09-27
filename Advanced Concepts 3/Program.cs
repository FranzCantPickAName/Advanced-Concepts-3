using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string str = "Developer";
            Console.WriteLine(str);

            Console.WriteLine("\nUpper: " + str.ToUpper());
            Console.WriteLine("Lower: " + str.ToLower());
            Console.WriteLine("Substring at 4: " + str.Substring(4));
            Console.WriteLine("Substring at 4 (3 characters): " + str.Substring(4, 3));
            Console.WriteLine("Replace: " + str.Replace("e", "a"));

            string message = "how are you";
            string[] words = message.Split(' ');
            Console.WriteLine("\nSplit:");
            foreach (string word in words) Console.WriteLine(word);

            string message_with_spaces = "   hello   ";
            Console.WriteLine(message_with_spaces.Trim());

            char[] characters = str.ToCharArray();
            Console.WriteLine("\nCharacters: ");
            foreach (char character in characters) Console.WriteLine(character);

            string[] my_words = new string[] { "how", "are", "you" };
            string str_jn = string.Join("--", my_words);
            Console.WriteLine("Join: " + str_jn);

            char[] characters2 = new char[] { 'h', 'e', 'l', 'l', 'o' };
            string str2 = new string(characters2);
            Console.WriteLine("New string: " + str2);

            Console.ReadKey();
        }
    }
}
