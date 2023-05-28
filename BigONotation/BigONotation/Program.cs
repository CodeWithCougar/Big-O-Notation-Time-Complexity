using System;
using System.Diagnostics;

namespace BigONotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigONotation b = new BigONotation();
            int[] arr1 = createArray(1000);
            int[] arr2 = createRandomArray(10);

            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();


            /*------------------------Execute your algorithm here--------------------------------------*/


            b.SumArr(arr1);




            /*----------------------------------------------------------------------------------------*/


            // Stop the stopwatch
            stopwatch.Stop();

            // Get the elapsed time as a TimeSpan value
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine();





            Console.WriteLine("Number of Operations: " + b.getNumberOfOperations());

            // format and display the TimeSpan value 
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            // Elapsed time in milliseconds
            long elapsedTimeInMilliseconds = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Elapsed time in milliseconds: {elapsedTimeInMilliseconds}");

            // Elapsed time in seconds
            double elapsedTimeInSeconds = stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine($"Elapsed time in seconds: {elapsedTimeInSeconds}");

            // Elapsed time in minutes
            double elapsedTimeInMinutes = stopwatch.Elapsed.TotalMinutes;
            Console.WriteLine($"Elapsed time in minutes: {elapsedTimeInMinutes}");


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
                array[i] = random.Next(1, 1000); 
            }
            return array;
        }
        public static void print(int[] array) //O(n)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}