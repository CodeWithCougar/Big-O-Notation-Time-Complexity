using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    internal class BigONotation
    {
        private int numberOfOperations;
        public BigONotation() 
        { 
            numberOfOperations = 0;
        }
        
        public int getNumberOfOperations()
        {
            return numberOfOperations;
        }
        /* #################  Constant Time O(1) ################# */
        /*
            In this function, regardless of the size of the array, the operation array[0]
            will always return the first element in the same amount of time. 
            Hence, this function has a constant time complexity of O(1).
         */
        public int GetFirstElement(int[] array)
        {
            return array[0]; // O(1)
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0; // O(1)
        }

        /*
         In this function, regardless of the size of the list, the operation
         list[index] = newValue will always update the element at the specified index in the same 
         amount of time. Hence, this function also has a constant time complexity of O(1).
        */
        public void UpdateElementAt(List<int> list, int index, int newValue)
        {
            if (index >= 0 && index < list.Count)
            {
                list[index] = newValue;
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range!");
            }
        }

        /* #################  Linear Time O(n) ################# */

        /*
             In this function, the time it takes to compute the sum directly depends on the size 
             of the input array. The larger the array, the longer it will take to compute the sum because
             it has to iterate through each element in the array once. Thus, 
             it has a linear time complexity of O(n).
         */
        public int SumArr(int[] array)
        {
            int sum = 0; numberOfOperations++;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i]; numberOfOperations++;
            }
            numberOfOperations++;
            return sum;
        }

        /*
             In this function, in the worst case scenario (when the target is not present in the array),
             it will have to check each element in the array once. Therefore, 
             this function also has a linear time complexity of O(n).
         */
        public bool Contains(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return true;
                }
            }
            return false;
        }

        /* #################  Logarithmic Time O(log n) ################# */

        /*
            In this function, with each iteration, the size of the problem is halved. Therefore, 
            it has a logarithmic time complexity of O(log n).
         */

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                
                int mid = left + (right - left) / 2;

                // Check if target is present at the mid
                if (array[mid] == target)
                    return mid;

                // If target greater, ignore left half  
                if (array[mid] < target)
                    left = mid + 1;

                // If target is smaller, ignore right half 
                else
                    right = mid - 1;
            }

            // Target is not present in array
            return -1;
        }




        /* #################  Quadratic Time O(n^2) ################# */

        public void Process2DArray(int[,] arr)
        {
            int n = arr.GetLength(0);  // number of rows
            int m = arr.GetLength(1);  // number of columns

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // process element arr[i,j]
                    // For example, print the element
                    Console.WriteLine(arr[i, j]);
                }
            }
        }

        public void Somefun(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    // some operation
                }
            }
        }



        /* #################  Cubic Time O(n^3) ################# */
        /*
         CubicTimeComplexity is a method that creates a 3D array with n elements in each dimension. 
         It then uses three nested loops to iterate over each element in the array, hence the cubic 
         time complexity O(n^3). For an input size of n, the total number of iterations is n * n * n, 
         which gives us the cubic time complexity.
         */
        static void CubicTimeComplexity(int n)
        {
            int[,,] arr = new int[n, n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        // Processing goes here
                        arr[i, j, k] = i + j + k;
                    }
                }
            }
        }


    }
}
