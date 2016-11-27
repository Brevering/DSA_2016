using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Sum_And_Average_Of_Sequence
{
    class Startup
    {
        static void Main()
        {
            IEnumerable<int> sequanceOfIntegers = new List<int>();

            sequanceOfIntegers =
                Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine("The sum of the elements in sequance is: {0}", sequanceOfIntegers.Sum());

            Console.WriteLine("The average of the elemets in sequance is: {0:F2}", sequanceOfIntegers.Average());
        }
    }
}
