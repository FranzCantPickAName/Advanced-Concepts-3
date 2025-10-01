using ClassLibrary1;
using System;
using System.Text;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string[] words = new string[] { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };

            string sentence = "";
            foreach (string word in words)
            {
                sentence = sentence + " " + word;
            }
            Console.WriteLine(sentence);

            //Doing the same, but with StringBuilder
            StringBuilder builder = new StringBuilder();
            foreach (string word in words)
            {
                builder.Append(word);
                builder.Append(" ");
                Console.WriteLine(builder.ToString() + ", " + builder.Length + ", " + builder.Capacity);
            }
            Console.WriteLine();

            StringBuilder builder2 = new StringBuilder(builder.ToString());
            builder[0] = 'v';
            Console.WriteLine(builder.ToString());
            Console.WriteLine(builder.MaxCapacity);

            Console.WriteLine(builder.Insert(5, "updated"));
            Console.WriteLine(builder.Remove(builder.ToString().IndexOf("q"), 5));
            Console.WriteLine(builder2.Remove(builder2.ToString().IndexOf("q"), 5));
            Console.WriteLine(builder.Replace("a", "r"));

            Console.ReadKey();
        }
    }
}
