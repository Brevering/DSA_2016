using System;
using System.Collections;
using System.Collections.Generic;

namespace _13.Implement_DynamicLinkedQueue
{
    public class CustomQueue<T> : IEnumerable<T> where T : IComparable<T>
    {
        private LinkedList<T> linkedList;

        public CustomQueue()
        {
            this.linkedList = new LinkedList<T>();
            this.Capacity = 0;
        }

        private int Capacity { get; set; }

        public void Enqueue(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("The value cannot be null!");
            }

            if (this.Capacity == 0)
            {
                this.linkedList.AddFirst(item);
            }
            else
            {
                this.linkedList.AddLast(item);
            }

            this.Capacity++;
        }

        public T Dequeue()
        {
            if (this.Capacity == 0)
            {
                throw new ArgumentNullException("The Queue is already empty!");
            }

            var removedItem = this.linkedList.First;
            this.linkedList.RemoveFirst();
            this.Capacity--;

            return removedItem.Value;
        }

        public T Peek()
        {
            if (this.Capacity == 0)
            {
                throw new ArgumentNullException("The Queue is empty!");
            }

            return this.linkedList.First.Value;
        }

        public int Count()
        {
            return this.Capacity;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = linkedList.First;
            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
