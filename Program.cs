using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type 1 to render alphabet A to Z, \ntype 2 to render alphabet Z to A, \ntype 3 to pick how many letters are skipped in rendering the alphabet: ");
            string userChoiceToRender = Console.ReadLine();
            string skippedLettersInput = null;
            if (userChoiceToRender == "3")
            {
                Console.WriteLine("How many letters do you want to skip in rendering the alphabet?");
                skippedLettersInput = Console.ReadLine();
            }
            int userChoiceNumber = Convert.ToInt32(userChoiceToRender), skippedLettersNumber = Convert.ToInt32(skippedLettersInput);
            Console.WriteLine(RenderUserChosenAlphabet(userChoiceNumber, skippedLettersNumber));
        }
        private static string RenderUserChosenAlphabet(int choice, int skip)
        {
            StringBuilder alphabetString = new StringBuilder();
            switch(choice)
            {
                case 1:
                    for(char letter = 'A'; letter <= 'Z'; letter++)
                    {
                        alphabetString.Append(letter);
                    }
                    break;
                case 2:
                    for(char letter = 'Z'; letter >= 'A'; letter--)
                    {
                        alphabetString.Append(letter);
                    }
                    break;
                case 3:
                    for (char letter = 'A'; letter <= 'Z'; letter = (char)(letter + skip))
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