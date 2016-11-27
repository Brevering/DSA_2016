using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Remove_Occur_Odd_Numbers
{
    class Startup
    {
        static void Main()
        {
            IList<double> sequenceOfNumbers = new List<double>();

            sequenceOfNumbers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var listWithEventOccurNumbers = RemoveNumbersWithOddOccur(sequenceOfNumbers);

            Console.WriteLine(string.Format("Sequence with even occur numbers only: {0}", string.Join(" ", listWithEventOccurNumbers)));
        }

        public static IEnumerable<double> RemoveNumbersWithOddOccur(IList<double> sequence)
        {
            var listWithNumbersWithEvenOccur = new List<double>();

            for (int i = 0; i < sequence.Count; i++)
            {
                var occurCount = 0;

                foreach (var number in sequence)
                {
                    if (sequence[i] == number)
                    {
                        occurCount++;
                    }
                }

                if (occurCount % 2 == 0)
                {
                    listWithNumbersWithEvenOccur.Add(sequence[i]);
                }
            }

            return listWithNumbersWithEvenOccur;
        }
    }
}
