using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("9_ClassesChallenge.Tests")]
namespace _9_ClassesChallenge
{
    internal class Human2
    {
        public string firstName;
        public string lastName;
        public string eyeColor;
        public int age;
        public static double Weight(double input)
        {
            if (0 < input || input > 400)
            {
                return 0;

            }
            else
            {
                return input;
            }

        }

        public Human2(string firstName, string lastName, string eyeColor, int age)
        {
            string firstName = "Smyth";
            string lastName = "Pat";
            string eyeColor = "hazel";
            int age = 40;
        }

        public Human2(string firstName, string lastName, int age)
        {
            string firstName = "Smyth";
            string lastName = "Pat";
            int age = 40;
        }

        public Human2(string firstName, string lastName, string eyeColor)
        {
            string firstName = "Smyth";
            string lastName = "Pat";
            string eyeColor = "hazel";
        }

        public static string AboutMe2(string firstName, string lastName, string eyeColor, int age)
        {

            return Console.WriteLine($"my name is + {firstName} + {lastName} + eyeColor +{eyeColor} + i am{age}");
        }

        Human2 h1 = new Human2("Ahmed", "Boujanoui", "hazel");
        Human2 h2 = new Human2("Ahmed", "Boujanoui", 33);
        Human2 h3 = new Human2("Ahmed", "Boujanoui", "hazel", 33);
        Human2 h4 = new Human2("A", "B", "HAZEL", 33, Weight(200));//instantiate human with a valid weight
        Human2 h5 = new Human2("A", "B", "HAZEL", 33, Weight(500));//instantiate human with an  invalid weight



    }
}