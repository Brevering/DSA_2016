using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Operations_Sequence
{
    class Startup
    {
        static void Main()
        {
            DisplayShortestSequence(5, 16);
        }

        private static void DisplayShortestSequence(int start, int target)
        {
            var sequence = new Queue<int>();

            while (start <= target)
            {
                sequence.Enqueue(target);

                if (target / 2 >= start)
                {
                    if (target % 2 == 0)
                    {
                        target /= 2;
                    }
                    else
                    {
                        target--;
                    }
                }
                else
                {
                    if (target - 2 >= start)
                    {
                        target -= 2;
                    }
                    else
                    {
                        target--;
                    }
                }
            }

            Console.WriteLine(string.Join(" -> ", sequence.Reverse()));
        }
    }
}
