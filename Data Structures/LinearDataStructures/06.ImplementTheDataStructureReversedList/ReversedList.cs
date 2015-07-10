namespace _06.ImplementTheDataStructureReversedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class ReversedList<T> : IEnumerable<T>
    {
        private T[] array;

        public ReversedList(int capacity = 4)
        {
            this.Capacity = capacity;
            this.array = new T[this.Capacity];
        }

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public void Add(T element)
        {
            if (this.Capacity == this.Count)
            {
                this.ResizeList();
            }

            if (this.Count == 0)
            {
                this.array[0] = element;
            }
            else
            {
                this.array[this.Count] = element;
            }

            this.Count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }
            int reversedIndex = this.Count - 1 - index;
            this.array[reversedIndex] = default(T);
            Array.Copy(this.array, reversedIndex + 1, this.array, reversedIndex, this.array.Length - 1 - reversedIndex);
            this.array[this.array.Length - 1] = default(T);
            this.Count--;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                return this.array[this.Count - 1 - index];
            }
            set
            {
                if (index < 0 || index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException("Index is out of range");
                }

                this.array[this.Count - 1 - index] = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void ResizeList()
        {
            T[] newArray = new T[this.array.Length];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.Capacity *= 2;
            this.array = new T[this.Capacity];
            Array.Copy(newArray, 0, this.array, 0, newArray.Length);
        }
    }
}
