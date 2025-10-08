using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Character 'A': ");

            char ch = 'A';
            byte b = (byte)ch;
            Console.WriteLine(b);
            char ch2 = (char)b;
            Console.WriteLine(ch2);

            Console.WriteLine("\nBytes from 0 to 127: ");

            byte[] bytes = new byte[128];
            for (byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }
            string s = System.Text.Encoding.ASCII.GetString(bytes);
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            Console.WriteLine(s);

            Console.WriteLine("\nSentence: ");

            string sentence = "The quick brown fox jumps over the lazy dog.";
            byte[] bytes2 = System.Text.Encoding.ASCII.GetBytes(sentence);
            foreach (byte item in bytes2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            string sentence2 = System.Text.Encoding.ASCII.GetString(bytes2);
            Console.WriteLine(sentence2);

            Console.ReadKey();
        }
    }
}
