using System;
using System.Collections;
using System.Collections.Generic;


namespace _11_ArraysAndListsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {1,2,3,4};
            var myArrayList = new ArrayList()
            {
                1, 2.0, 'x', 3, 'y', 3.3
            };
            Console.WriteLine(AverageOfValues(int[] array));
            Console.WriteLine(SunIsShining(x));

        }//EoM

        /// <summary>
        /// This method takes an array of integers and returns a double, the average 
        /// value of all the integers in the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static double AverageOfValues(int[] array)
        {
            double average = 0;
            int sum = 0;
            for(int i =0;  i < array.Length; i++)
            {
                sum = sum +array[i];

            }
            return average = sum/array.Length;

        }

        /// <summary>
        /// This method increases each array element by 2 and 
        /// returns an array with the altered values.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] SunIsShining(int[] x)
        {
            for(int i =0; i< x.Length; i++)
            {
                x[i]= x[i]+2;

            }
            return x;
        }

        /// <summary>
        /// This method takes an ArrayList containing types of double, int, and string 
        /// and returns the average of the ints and doubles only, as a decimal.
        /// It ignores the string values and rounds the result to 3 decimal places toward the nearest even number.
        /// </summary>
        /// <param name="myArrayList"></param>
        /// <returns></returns>
        public static decimal ArrayListAvg(ArrayList myArrayList)
        {
            decimal average =0;
            double sum =0;
            for (int i = 0 ; i < myArrayList.Count; i++)
            {
                sum = sum + myArrayList[i];
            }
            return average = (sum/myArrayList.Count);
            
        }

        /// <summary>
        /// This method returns the rank (starting with 1st place) of a new 
        /// score entered into a list of randomly ordered scores.
        /// </summary>
        /// <param name="myArray1"></param>
        public static int ListAscendingOrder(List<int> scores, int yourScore)
        {
            scores.Add(yourScore);
            int rank =0;
            var result = scores.OrderBy(num=>num);
            for (int i = 0; i < result.Count; i++ )
            {
                if( result[i] == yourScore)
                    rank = i;
            }
            return rank;
        }

        /// <summary>
        /// This method has with two parameters takes a List<string> and a string.
        /// The method returns true if the string parameter is found in the List, otherwise false.
        /// </summary>
        /// <param name="myArray2"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool FindStringInList(List<string> myArray2, string word)
        {
            if(bool exists = myArray2.Any(s => myArray2.Contains(word)))
                    return true;

        }
    }//EoP
}// EoN