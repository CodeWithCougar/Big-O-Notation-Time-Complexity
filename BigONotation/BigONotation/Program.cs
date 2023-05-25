using System;

namespace BigONotation
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BigONotation b = new BigONotation();
            int[] arr1 = createArray(10);
            int[] arr2 = createRandomArray(10);
            
            Console.WriteLine("Number of Operations: " + b.getNumberOfElements());

        }

        public static int[] createArray(int size)
        {
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                array[i] = i+1;
            }
            return array;
        }
        public static int[] createRandomArray(int size)
        {
            // Create a new instance of the Random class
            Random random = new Random();
            
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                // Generate a random integer between a specified range
                array[i] = random.Next(1, 10000); // Generates a random number between 1 and 100;
            }
            return array;
        }
        public static void print(int[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}