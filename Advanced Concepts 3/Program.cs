using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string name = "developer@example.com";
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;
            for (int i = 0; i < name.Length; i++)
            {
                //bool isMatch = false;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (name[i] == vowels[j])
                    {
                        //isMatch = true;
                        vowelsCount++;
                    }
                }
                //if (isMatch)
                //{
                //    vowelsCount++;
                //}
            }

            Console.WriteLine(vowelsCount + " vowels found.");
            Console.WriteLine();

            //Alternative using only one for loop
            vowelsCount = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (Array.IndexOf(vowels, name[i]) >= 0)
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount + " vowels found.");

            Console.ReadKey();
        }
    }
}
