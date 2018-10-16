﻿using System;
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
    }
}
