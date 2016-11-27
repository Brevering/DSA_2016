using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Number_Occurence
{
    class Startup
    {
        static void Main()
        {
            IEnumerable<double> sequenceOfNumbers = new List<double>();

            sequenceOfNumbers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(number => double.Parse(number))
                .ToList();

            var dictionaryWithOccurences = new SortedDictionary<double, int>();

            foreach (var number in sequenceOfNumbers)
            {
                if (dictionaryWithOccurences.ContainsKey(number))
                {
                    dictionaryWithOccurences[number]++;
                }
                else
                {
                    dictionaryWithOccurences.Add(number, 1);
                }
            }

            foreach (var occurence in dictionaryWithOccurences)
            {
                Console.WriteLine("{0} --> {1} times", occurence.Key, occurence.Value);
            }
        }
    }
}
