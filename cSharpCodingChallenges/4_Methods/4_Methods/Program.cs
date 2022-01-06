using System;

namespace _4_MethodsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetName();

        }

        public static string GetName()
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            return name;
        }

        public static string GreetFriend(string name)
        {
            Console.WriteLine("what is your name?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"hello {name1}");

        }

        public static double GetNumber()
        {

            do
            {
                Console.WriteLine("enter a double number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter another double number");
                double num2 = Convert.ToDouble(Console.ReadLine());
            }
            while (!(num1 && num2));
            return double num1 + num2;              
        }

        public static int GetAction()
        {
            int choice = 0;
            while (choice != 1 || choice != 2 || choice != 3 || choice != 4);
            {
                Console.WriteLine(" [1] to ADD\n  [2] to SUBSTRACT\n [3] to MULTIPLY\n [4] to DIVIDE");
                choice = int.Parse(Console.ReadLine());
            }
            


            
            
        }

        public static double DoAction(double x, double y, int action)
        {
            switch(choice)
            {case 1:
                    return x+y;

                    break;
            case 2:return x-y;

                    break;
            case 3: 
                    return x*y;
                    break;
            case 4:
                    return x/y ;
                    break;
            default:
                    Console.WriteLine("unhandlled Exception.");
                    break;
                        





            }
        }
    }
}
