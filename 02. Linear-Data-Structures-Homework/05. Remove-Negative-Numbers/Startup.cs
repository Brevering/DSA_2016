using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Remove_Negative_Numbers
{
    class Startup
    {
        static void Main()
        {
            {
                IEnumerable<double> sequanceOfPositiveIntegers = new List<double>();

                sequanceOfPositiveIntegers =
                    Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(number => double.Parse(number))
                    .Where(integer => integer >= 0)
                    .ToList();

                Console.WriteLine(string.Format("Sequence with positive numbers only: {0}", string.Join(" ", sequanceOfPositiveIntegers)));
            }
        }
    }
}
