using System;
using System.Text;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            CodeLouisvilleStudent hamzaFoy = new CodeLouisvilleStudent("Hamza", "Foy");
            hamzaFoy.introduceOneself();
            RenderAlphabetQuicker();
        }

        private static void RenderAlphabetQuicker()
        {
            StringBuilder sb = new StringBuilder();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                sb.Append(letter);
            }

            Console.WriteLine(sb.ToString());
        }
        private static void RenderAlphabetWithoutStringBuilder()
        {
            string alphabetString = "";
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetString += i.ToString();
                }

            }
            Console.WriteLine(alphabetString);
        }



        private static void RenderAlphabet()
        {
            StringBuilder alphabetString = new StringBuilder();
            for (char i = char.MinValue; i < char.MaxValue; i++)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetString.Append(i);
                }

            }
            Console.WriteLine(alphabetString.ToString());
        }



        private static void RenderAlphabetSkipped()
        {
            StringBuilder alphabetString = new StringBuilder();
            char letter = 'A';
            while (letter <= 'Z')
            {
                alphabetString.Append(letter);
                letter++;
                letter++;
            }
            Console.WriteLine(alphabetString.ToString());
        }



        private static void RenderAlphabetBackwards()
        {
            StringBuilder alphabetstring = new StringBuilder();
            for (char i = char.MaxValue; i > char.MinValue; i--)
            {
                if (i >= 'A' && i <= 'Z')
                {
                    alphabetstring.Append(i);
                }

            }
            Console.WriteLine(alphabetstring.ToString());
        }
    }

    public abstract class Person
    {
        public abstract void introduceOneself();
        public abstract void describeOneself();
    }
    
    public class CodeLouisvilleStudent: Person
    {
        public const bool partOfCodeLouisville = true;
        private string firstName;
        private string lastName;
        public CodeLouisvilleStudent(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public override void introduceOneself()
        {
            Console.WriteLine($"Hello you all, my name is {firstName} {lastName}");
        }
        public override void describeOneself()
        {
            throw new NotImplementedException();
        }

    }

}