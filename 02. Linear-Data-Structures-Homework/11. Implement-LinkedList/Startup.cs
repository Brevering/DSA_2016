using System;

namespace _11.Implement_LinkedList
{
    class Startup
    {
        static void Main()
        {
            var implementedLinkedList = new LinkedList<int>();

            var headItem = new ListItem<int>(5);
            implementedLinkedList.FirstElement = headItem;

            var nextItem = new ListItem<int>(7);
            var secondNextItem = new ListItem<int>(11);

            headItem.NextItem = nextItem;
            nextItem.NextItem = secondNextItem;

            var currentItem = headItem;

            Console.Write(string.Join(", ", implementedLinkedList));
            Console.WriteLine();
        }
    }
}
