using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Longest_Subsequence
{
    class Startup
    {
        static void Main()
        {
            IList<double> sequenceOfIntegers = new List<double>();

            sequenceOfIntegers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(integer => double.Parse(integer))
                .ToList();

            var longestSubsequence = LongestSubsequenceOfEqualNumbers(sequenceOfIntegers);

            Console.WriteLine(string.Format("Longest repeating sequence: {0}", string.Join(" ", longestSubsequence)));
        }

        public static IEnumerable<double> LongestSubsequenceOfEqualNumbers(IList<double> sequence)
        {
            var mostFrequentNumber = 0d;
            var subsequenceCount = 1;
            var maximalSubsequenceCount = 1;

            for (int i = 0; i < sequence.Count - 1; i++)
            {
                var currentElement = sequence[i];
                var nextElement = sequence[i + 1];

                if (currentElement == nextElement)
                {
                    subsequenceCount++;
                }
                else
                {
                    subsequenceCount = 1;
                }

                if (subsequenceCount > maximalSubsequenceCount)
                {
                    maximalSubsequenceCount = subsequenceCount;
                    mostFrequentNumber = sequence[i];
                }        
            }

            return Enumerable.Repeat(mostFrequentNumber, maximalSubsequenceCount).ToList();
        }
    }
}
