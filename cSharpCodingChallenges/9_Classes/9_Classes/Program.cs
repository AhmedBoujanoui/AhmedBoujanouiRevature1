using System;

namespace _9_ClassesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Human.AboutMe("Ahmed","Boujanoui");
            Human.AboutMe(h1);

            Human2.AboutMe2(h1);
            Human2.AboutMe2(h2);
            Human2.AboutMe2(h3);
            Console.WriteLine(Human2.Weight(500));

        }
    }
}
