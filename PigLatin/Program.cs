using System;
using System.Text;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            do
            {
                Console.WriteLine("Enter a word");
                string input = Console.ReadLine();
                string output = TranslateToPigLatin(input);
            } while (answer.ToLower().Equals("y"));

        }

        private static string TranslateToPigLatin(string input)
        {
            string result = "";

            string lower = input.ToLower();

            return result;
        }
    }
}
