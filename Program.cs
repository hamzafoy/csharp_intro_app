using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RenderAlphabetQuicker());
            Console.WriteLine(RenderAlphabetSkipped());
            Console.WriteLine(RenderAlphabetBackwards());
        }
        private static string RenderAlphabetQuicker()
        {
            StringBuilder sb = new StringBuilder();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                sb.Append(letter);
            }

            return sb.ToString();
        }
        private static string RenderAlphabetSkipped()
        {
            StringBuilder alphabetString = new StringBuilder();
            char letter = 'A';
            while (letter <= 'Z')
            {
                alphabetString.Append(letter);
                letter++;
                letter++;
            }
            return alphabetString.ToString();
        }
        private static string RenderAlphabetBackwards()
        {
            StringBuilder alphabetstring = new StringBuilder();
            for (char letter = 'Z'; letter >= 'A'; letter--)
            {
                alphabetstring.Append(letter);
            }
            return alphabetstring.ToString();
        }

    }

}