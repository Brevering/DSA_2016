using System;

namespace _13.Implement_DynamicLinkedQueue
{
    class Startup
    {
        static void Main()
        {
            var queue = new CustomQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(-6);
            queue.Enqueue(2);
            queue.Enqueue(11);
            queue.Enqueue(7);

            Console.WriteLine("Peek element: {0}", queue.Peek());

            Console.WriteLine("Count of elements in queue: {0}", queue.Count());

            Console.WriteLine("Dequeue element [{0}]", queue.Dequeue());

            Console.WriteLine("Count of elements after the dequeue in queue: {0}", queue.Count());

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}
