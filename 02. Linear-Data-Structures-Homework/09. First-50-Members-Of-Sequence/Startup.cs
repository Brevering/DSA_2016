using System;
using System.Collections.Generic;

namespace _09.First_50_Members_Of_Sequence
{
    class Startup
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            ICollection<int> listWithFirst50Members = new List<int>();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(number);

            for (int i = 0; i < 50; i++)
            {
                listWithFirst50Members.Add(queue.Peek());

                int current = queue.Dequeue();

                queue.Enqueue(current + 1);
                queue.Enqueue((2 * current) + 1);
                queue.Enqueue(current + 2);
            }

            Console.WriteLine(string.Join(", ", listWithFirst50Members));
        }
    }
}
