using System;
using System.Diagnostics;

namespace AmIStupidApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"SumOfAnArray([1, -2, 3, 4, 5]): {SumOfAnArray(new int[] { 1, -2, 3, 4, 5 })}");
            Console.WriteLine($"ReverseString(\"esrever\"): {ReverseString("esrever")}");
            Console.WriteLine($"CountVowels(string input): {CountVowels("eiou")}");
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
        /// <summary>
        /// Function that takes a single string as input.
        /// Returns the string in reverse order.
        /// </summary>
        /// <param name="input">String to be reversed.</param>
        /// <returns></returns>
        public static string ReverseString(string input)
        {
            if (input == null) return ""; // Handle null input
            if (input.Length == 0) return ""; // Handle empty string

            string reversed = "";

            for (int idx = input.Length - 1; idx >= 0; idx--)
            {
                reversed += input[idx];
            }
            return reversed;
        }
        /// <summary>
        /// Function that takes a string as input.
        /// Counts how many vowels (a, e, i, o, u) appear in the string.
        /// Returns that count.
        /// </summary>
        /// <param name="input">String to count vowels in.</param>
        /// <returns>Number of vowels in the input string.</returns>
        public static int CountVowels(string input)
        {
            if (input == null) return 0; // Handle null input
            if (input.Length == 0) return 0; // Handle empty array

            char[] testFor = { 'a', 'e', 'i', 'o', 'u' };
            int cnt = 0;

            for (int idx = 0; idx < input.Length; idx++)
            {
                for (int testForIdx = 0; testForIdx < testFor.Length; testForIdx++)
                {
                    if ((char)input[idx] == testFor[testForIdx])
                    {
                        cnt++;
                        break;
                    }
                }
            }

            return cnt;
        }
    }
}