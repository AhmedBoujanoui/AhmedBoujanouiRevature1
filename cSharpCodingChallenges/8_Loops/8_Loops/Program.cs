using System;
using System.Collections.Generic;

namespace _8_LoopsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Your code here */
            List<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            UseFor(test);
            UseForEach(test);
            UseForThreeFour(test);

        }

        /// <summary>
        /// Return the number of elements in the List<int> that are odd.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseFor(List<int> x)
        {
            int OddCounter = 0;
            for (int i = 0; i<x.Count; i++)
            {
                if(x[i]%2 !=0)
                {
                    OddCounter += OddCounter;
                }
                return OddCounter;

            }
        }

        /// <summary>
        /// This method counts the even entries from the provided List<object> 
        /// and returns the total number found.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForEach(List<object> x)
        {
            int evencounter = 0;
            foreach(var i in x)
            {
                int myvar = Convert.ToInt32(i);
                if (myvar % 2 == 0)
                {
                    evencounter += 1;
                }
                return evencounter;

            }
        }

        /// <summary>
        /// This method counts the multiples of 4 from the provided List<int>. 
        /// Exit the loop when the integer 1234 is found.
        /// Return the total number of multiples of 4.
        /// </summary>
        /// <param name="x"></param>
        public static int UseWhile(List<int> x)
        {

            int multipleCounter = 0;

            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] % 4 == 0 && x[i] != 1234)
                {
                    multipleCounter += 1;
                }
                return multipleCounter;

            }



        }

        /// <summary>
        /// This method will evaluate the Int Array provided and return how many of its 
        /// values are multiples of 3 and 4.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int UseForThreeFour(int[] x)
        {
            int multipleCounter = 0;
            for(int i =0; i<x.Length; i++)
            {
                if(x[i] % 3 == 0 && x[i] % 4 ==0)
                {
                    multipleCounter += 1;
                }
                return multipleCounter;


            }

        }

        /// <summary>
        /// This method takes an array of List<string>'s. 
        /// It concatenates all the strings, with a space between each, in the Lists and returns the resulting string.
        /// </summary>
        /// <param name="stringListArray"></param>
        /// <returns></returns>
        public static string LoopdyLoop(List<string>[] stringListArray)
        {
            foreach(string var in stringListArray)
            {
                var unreadablePhrase = string.Concat(stringListArray);


            }
        }
    }
}