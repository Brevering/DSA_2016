using System;
using System.Collections;
using System.Collections.Generic;

namespace _12.Implement_Stack
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private const int InitialStackSize = 4;
        private const int SizeDelta = 4;

        private T[] elements;
        private int currentStackSize;

        public CustomStack()
        {
            this.elements = new T[InitialStackSize];
        }

        public int Capacity()
        {
            return this.elements.Length;
        }

        public T Peek()
        {
            if (this.currentStackSize <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            return this.elements[currentStackSize - 1];
        }

        public void Push(T item)
        {
            if (currentStackSize == this.Capacity())
            {
                this.elements = this.ResizeArray();
            }

            this.elements[currentStackSize] = item;

            this.currentStackSize++;
        }

        public T Pop()
        {
            if (this.currentStackSize <= 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            this.currentStackSize--;

            var item = this.elements[this.currentStackSize];

            this.elements[this.currentStackSize] = default(T);

            return item;
        }

        private T[] ResizeArray()
        {
            var resizedArray = new T[this.Capacity() + SizeDelta];

            for (int i = 0; i < this.elements.Length; i++)
            {
                resizedArray[i] = this.elements[i];
            }

            return resizedArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var i = 0;

            while (i < this.currentStackSize)
            {
                yield return this.elements[i];

                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
