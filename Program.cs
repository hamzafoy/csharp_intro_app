using System;

namespace GeneralProgramForCodeLouisville
{
    public class Program
    {
        static void Main(string[] args)
        {
            CodeLouisvilleStudent hamzaFoy = new CodeLouisvilleStudent("Hamza", "Foy");
            hamzaFoy.introduceOneself();
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