using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Reverse_Sequance_Using_Stack
{
    class Startup
    {
        static void Main()
        {
            IEnumerable<int> sequanceOfIntegers = new List<int>();
            Stack<int> reversedSequanceOfIntegers = new Stack<int>();

            sequanceOfIntegers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            foreach (var integer in sequanceOfIntegers)
            {
                reversedSequanceOfIntegers.Push(integer);
            }

            Console.WriteLine(string.Join(" ", reversedSequanceOfIntegers));
        }
    }
}
