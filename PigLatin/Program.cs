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
            StringBuilder consonants = new StringBuilder();

            string lower = input.ToLower();

            if (vowels.Contains(lower[0].ToString()))
            {
                sb.Append(lower);
                sb.Append("way");
                return sb.ToString();
            }

            for (int i = 0; i < lower.Length; i++)
            {
                if (!vowels.Contains(lower[i].ToString()))
                {
                    consonants.Append(lower[i]);
                }
                else
                {
                    sb.Append(lower.Substring(i));
                    sb.Append(consonants.ToString());
                    sb.Append("ay");
                }
            }

            return sb.ToString();
        }
    }
}
