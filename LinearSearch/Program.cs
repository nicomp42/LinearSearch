/***********************************************************************************
 * Demonstrate a linear search on an array of integers                             *
 * What is best case, worst case, and average case for this search algorithm?      *
 * Is an array a 'correct' data structure for this application?                    *
 * *********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 42, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int idx = LinearSearch(test, 5);
            Console.WriteLine("value 5 found at index " + idx);
            if (idx == 6) { Console.WriteLine("Test passed");} else {Console.WriteLine("Test FAILED"); }
        }

        /// <summary>
        /// Perform a linear search on an array of integers
        /// </summary>
        /// <param name="myArray">The array to be searched</param>
        /// <param name="target">The value to be searched for</param>
        /// <returns>the index of target or -1 if target is not in myArray</returns>
        public static int LinearSearch(int[] myArray, int target)
        {
            int idx = -1;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == target) { idx = i; break; }
            }
            return idx;
        }
    }
}
