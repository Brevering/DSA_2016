using System.Collections;
using System.Collections.Generic;

namespace _11.Implement_LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public LinkedList()
        {

        }

        public LinkedList(ListItem<T> firstElement)
        {
            this.FirstElement = firstElement;
        }

        public ListItem<T> FirstElement { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var currentItem = this.FirstElement;

            while (currentItem != null)
            {
                yield return currentItem.Value;
                currentItem = currentItem.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
