using System;
using System.Diagnostics;

namespace AmIStupidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"SumOfAnArray([1, -2, 3, 4, 5]): {SumOfAnArray([1, -2, 3, 4, 5])}");
        }

        /// <summary>
        /// Function that takes an array of numbers as input.
        /// Computes and returns the sum of all the numbers in that array.
        /// </summary>
        /// <param name="a">Array of numbers to be summed up.</param>
        /// <returns></returns>
        public static int SumOfAnArray(int[] a)
        {
            if (a == null) return 0; // Handle null input
            if (a.Length == 0) return 0; // Handle empty array

            int acc = 0;
            for (int idx = 0; idx < a.Length; idx++)
            {
                acc += a[idx];
            }
            return acc;
        }
    }
}