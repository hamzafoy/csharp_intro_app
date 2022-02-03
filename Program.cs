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
            Console.WriteLine(userChoiceToRender);
            string skippedLettersInput = "1";
            if (userChoiceToRender == "3")
            {
                Console.WriteLine("How many letters do you want to skip in rendering the alphabet?");
                skippedLettersInput = Console.ReadLine();
                skippedLettersInput = (skippedLettersInput != "") ? skippedLettersInput : "1";
            }
            int userChoiceNumber = (userChoiceToRender != "") ? Convert.ToInt32(userChoiceToRender) : 1;
            int skippedLettersNumber = int.Parse(skippedLettersInput);
            Console.WriteLine(RenderUserChosenAlphabet(userChoiceNumber, skippedLettersNumber));
        }
        private static string RenderUserChosenAlphabet(int choice = 1, int skip = 1)
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
    }
}