using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human
    {
        private string lastName = "Smyth";
        private string firstName = "Pat";

        public Human(string firstName, string lastName)
        {
            firstName = "Smyth";
            lastName = "Pat";
        }

        public Human()
        {
        }


        Human h1 = new Human();
        Human h2 = new Human("Smyth", "Pat");

        public static string AboutMe(string firstName, string lastName)
        {
            Console.WriteLine($"My name is + {firstName}+ {lastName}");


        }


    }//end of class
}//end of namespace