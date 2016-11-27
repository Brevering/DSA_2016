using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Majorant_Of_An_Array
{
    class Startup
    {
        static void Main()
        {
            IList<double> sequenceOfNumbers = new List<double>();

            sequenceOfNumbers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(number => double.Parse(number))
                .ToList();

            var majorant = sequenceOfNumbers
                .GroupBy(number => number)
                .ToDictionary(key => key.Key, value => value.Count())
                .First(number => number.Value >= sequenceOfNumbers.Count / 2 + 1)
                .Key;

            var list = sequenceOfNumbers.GroupBy(x => x)
                .ToList();

            Console.WriteLine("Majorant --> {0}", majorant);
        }
    }
}
