using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    internal class SimplifyingRules
    {

      /*
         Best-case scenario: Items is the first element 
         Average-case: the item is some where in the middle 
         Worst-case: the item is the last item or item is not present in the array
     */
        public bool FindItem(int[] array, int item)
        {
            foreach (var x in array)
            {
                if (x == item)
                    return true;
            }
            return false;
        }
        // The time complexity of this function is O(n) because,
        // in the worst case, it will iterate through every element in the array.


        /*
                        1- Analyze the worst-case scenario: 
        Consider a function that finds the maximum number in an array. 
        In the worst-case scenario, the maximum number would be the last element, 
        so you would have to iterate through the entire array:
        the best-case scenario 
         */
        public int FindMax(int[] array)
        {
            int max = int.MinValue; // O(1)
            for (int i = 0; i < array.Length; i++) // O(n)
            {
                if (array[i] > max) // O(1)
                {
                    max = array[i]; // O(1)
                }
            }
            return max; // O(1)
        }





        /*
                        2- Ignore constant factors: 
        Let's say we have a function that processes each element in an array twice:
         */
        public void ProcessArrayTwice(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // O(n)
            {
                // some operation
            }

            for (int i = 0; i < array.Length; i++) // O(n)
            {
                // some other operation
            }
        }
        //The time complexity is 2n, but when we apply Big O notation,
        //we ignore the constant factor of 2 and simplify it to O(n).

        public void printOddEven(int[] array)
        {
            if(array.Length >=2)
            {
                array[0] = 0; // O(1)
                array[array.Length-1] = 100; // O(1)
            }

            for(int i = 0; i< array.Length;i++) // O(n)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]+ " is even"); // O(1)
                }

            }
            Console.WriteLine("End of Array"); // O(1)
        }




        /*
                            3- Differentiate terms for separate inputs: 
        When a function processes two or more different inputs independently, 
        represent each one with a different variable:
         */

        void ProcessArrayAndString(int[] array, string str, int[] ar)
        {
            for (int i = 0; i < array.Length; i++) // O(n)
            {
                // some operation on array
            }

            for (int i = 0; i < str.Length; i++) // O(m)
            {
                // some operation on string
            }
        }
        //Here, the time complexity is O(n + m),
        //where n is the size of the array and m is the length of the string.




        /*
         4- Drop non-dominant terms: 
        If a function has multiple loops, 
        one nested and one not, you can drop the non-dominant term:
         */
        void SomeFunction(int[] array)
        {

            for (int i = 0; i < array.Length; i++) // n
            {
                for (int j = 0; j < array.Length; j++) // n
                {
                    // some operation
                }
            }

            for (int i = 0; i < array.Length; i++) // n
            {
                // some operation
            }
        }
        //The time complexity here is O(n² + n).
        //However, as n grows, the n² term becomes the dominant factor, so we simplify this to O(n²).


        /*
            The time complexity of this function is O(n), where n is the size of the input array.

            Here's why: The outer loop runs once for each element in the array, 
            so it has a time complexity of O(n). The inner loop always runs 10 times, 
            regardless of the size of the array. Since the number of iterations of the inner loop is constant
            and does not grow with the size of the input, we say it has a time complexity of O(1).
         */
        public void Somefun(int[] array)
        {
            for (int i = 0; i < array.Length; i++) // O(n)
            {
                for (int j = 0; j < 10; j++) // O(10)
                {
                    // some operation
                }
            }
        }

    }

    
}
