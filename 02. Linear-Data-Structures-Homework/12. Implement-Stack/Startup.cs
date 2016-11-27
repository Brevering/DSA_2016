using System;

namespace _12.Implement_Stack
{
    class Startup
    {
        static void Main()
        {
            var stack = new CustomStack<string>();

            stack.Push("Cat");
            Console.WriteLine("Pop element: {0}", stack.Pop());

            stack.Push("Dog");
            stack.Push("Elephant");

            Console.WriteLine("Peek element: {0}", stack.Peek());

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
