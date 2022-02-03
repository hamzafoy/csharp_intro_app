using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Setting variable to store User's numerical choice to pick rendering option to null outside the do-while loop
            //in order to access it for the `while` condition.
            string userChoiceToRender = null;
            do
            {
                Console.Write("Type 1 to render alphabet A to Z\nType 2 to render alphabet Z to A\nType 3 to pick how many letters are skipped in rendering the alphabet\nHit the [SPACEBAR] to exit the program:  ");
                if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                {
                    //Spacebar press will utilize break to end the program.
                    break;
                }
                userChoiceToRender = Console.ReadLine();
                string skippedLettersInput = "1";
                if (userChoiceToRender == "3")
                {
                    Console.WriteLine("How many letters do you want to skip when rendering the alphabet?");
                    skippedLettersInput = Console.ReadLine();
                    //Ensures the program doesn't break if one were to prematurely press ENTER without submitting a response to the prompt.
                    skippedLettersInput = (skippedLettersInput != "") ? skippedLettersInput : "1";
                }
                int userChoiceNumber = (userChoiceToRender != "") ? Convert.ToInt32(userChoiceToRender) : 1;
                int skippedLettersNumber = int.Parse(skippedLettersInput);
                Console.WriteLine(RenderUserChosenAlphabet(userChoiceNumber, skippedLettersNumber));
            } while (userChoiceToRender != null);
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
    }
}