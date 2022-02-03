using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type 1 to render alphabet A to Z, type 2 to render alphabet Z to A: ");
            string userChoiceToRender = Console.ReadLine();
            Console.WriteLine(RenderUserChosenAlphabet(userChoiceToRender = "1"));
        }
        private static string RenderUserChosenAlphabet(string choice)
        {
            StringBuilder alphabetString = new StringBuilder();
            switch(choice)
            {
                case "1":
                    for(char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        alphabetString.Append(letter);
                    }
                    break;
                case "2":
                    for(char letter = 'Z'; letter >= 'A'; letter--)
                    {
                        alphabetString.Append(letter);
                    }
                    break;
            }
            return alphabetString.ToString();
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