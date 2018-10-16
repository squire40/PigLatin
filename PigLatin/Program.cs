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
            StringBuilder phrase = new StringBuilder();
            do
            {
                Console.WriteLine("Enter a word");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter valid input");
                }
                else
                {
                    var output = input.Split(' ');
                    foreach (var word in output)
                    {
                        phrase.Append($"{TranslateToPigLatin(word)} ");
                    }
                    Console.WriteLine(phrase.ToString());
                }

                Console.WriteLine("Continue? y/n");
                answer = Console.ReadLine();
            } while (answer.ToLower().Equals("y"));

        }

        private static string TranslateToPigLatin(string input)
        {
            if (!ContainsOnlyLetters(input))
            {
                return input;
            }
            StringBuilder sb = new StringBuilder();
            StringBuilder consonants = new StringBuilder();

            if (vowels.Contains(input[0].ToString().ToLower()))
            {
                sb.Append(input);
                sb.Append("way");
                return sb.ToString();
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!vowels.Contains(input[i].ToString().ToLower()))
                {
                    consonants.Append(input[i]);
                }
                else
                {
                    sb.Append(input.Substring(i));
                    sb.Append(consonants.ToString());
                    sb.Append("ay");
                    break;
                }
            }

            return sb.ToString();
        }

        private static bool ContainsOnlyLetters(string input)
        {
            bool result = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetter(input[i]))
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
