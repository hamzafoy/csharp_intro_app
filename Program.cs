using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1-10 to produce an alphabet that increments by the number you provide: ");
            string userInput = Console.ReadLine();
            int userInputFixed = Convert.ToInt32(userInput = "1");
            Console.WriteLine(RenderAlphabetQuicker());
            Console.WriteLine(RenderAlphabetSkipped(userInputFixed));
            Console.WriteLine(RenderAlphabetBackwards());
        }
        private static string RenderAlphabetQuicker()
        {
            StringBuilder alphabetString = new StringBuilder();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                alphabetString.Append(letter);
            }
            return alphabetString.ToString();
        }
        private static string RenderAlphabetSkipped(int? userInputFixed = 1)
        {
            StringBuilder alphabetString = new StringBuilder();
            for (char letter = 'A'; letter <= 'Z'; letter = (char)(letter + userInputFixed))
            {
                alphabetString.Append(letter);
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