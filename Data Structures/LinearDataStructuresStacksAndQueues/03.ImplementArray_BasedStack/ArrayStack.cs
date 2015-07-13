namespace _03.ImplementArray_BasedStack
{
    using System;

    public class ArrayStack<T>
    {
        private const int InitialCapacity = 16;
        private T[] elements;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Count { get; private set; }

        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }

            this.Count--;
            var lastElement = this.elements[this.Count];

            return lastElement;
        }

        public T[] ToArray()
        {
            var newArray = new T[this.Count];
            int index = 0;
            for (int i = this.Count - 1; i >= 0; i--)
            {
                newArray[index++] = this.elements[i];
            }

            return newArray;
        }

        private void Grow()
        {
            var newElements = new T[this.elements.Length * 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            for (int i = 0; i < this.Count; i++)
            {
                resultArr[i] = this.elements[i];
            }
        }
    }
}
