using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigONotation
{
    internal class BigONotation
    {
        private int numberOfOperations;
        public BigONotation() 
        { 
            this.numberOfOperations = 0;
            
        }
        public int getNumberOfElements() { return this.numberOfOperations; }

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
                numberOfOperations++;
                if (array[i] == target)
                {
                    return true;
                }
            }
            return false;
        }

        /* #################  Linear Time O(n) ################# */

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

    }
}
