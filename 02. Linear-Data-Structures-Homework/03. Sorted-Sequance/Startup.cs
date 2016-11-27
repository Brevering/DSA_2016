using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sorted_Sequance
{
    class Startup
    {
        static void Main()
        {
            IEnumerable<int> sequanceOfIntegers = new List<int>();

            sequanceOfIntegers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(integer => int.Parse(integer))
                .OrderBy(integer => integer)
                .ToList();

                Console.WriteLine(string.Join(" ", sequanceOfIntegers));
        }
    }
}
