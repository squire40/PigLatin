using System;
using System.Text;

namespace PigLatin
{
    class Program
    {
        const string vowels = "aeiou";
        static void Main(string[] args)
        {
            string answer = null;
            do
            {
                Console.WriteLine("Enter a word");
                string input = Console.ReadLine();
                string output = TranslateToPigLatin(input);
                Console.WriteLine(output);
                Console.WriteLine("Continue? y/n");
                answer = Console.ReadLine();
            } while (answer.ToLower().Equals("y"));

        }

        private static string TranslateToPigLatin(string input)
        {
            StringBuilder sb = new StringBuilder();

            string lower = input.ToLower();



            return sb.ToString();
        }
    }
}
