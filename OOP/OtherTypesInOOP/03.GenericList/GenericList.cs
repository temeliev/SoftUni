namespace _03.GenericList
{
    using System;
    using System.Linq;

    [_04.GenericListVersion.VersionAttribute(Version = 1.1)]
    public class GenericList<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] array;

        private int lastIndex;

        public GenericList(int size = DefaultSize)
        {
            this.array = new T[size];
            this.lastIndex = 0;
        }

        public void Add(T element)
        {
            if (this.lastIndex >= this.array.Length)
            {
                this.Resize(this.array.Length * 2);
            }

            this.array[this.lastIndex] = element;
            this.lastIndex++;
        }

        public T this[int i]
        {
            get { return this.array[i]; }
        }

        public void Remove(T element)
        {
            if (!this.Contains(element))
            {
                throw new InvalidOperationException("There is no such element!");
            }

            int index = -1;

            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(element))
                {
                    this.array[i] = default(T);
                    index = i;
                    break;
                }
            }

            this.lastIndex--;
            this.ReArrange(index);
        }

        public void Insert(T element, int index)
        {
            if (index > this.lastIndex || index < 0)
            {
                throw new ArgumentOutOfRangeException("Index is out of boundary!");
            }

            if (this.lastIndex + 1 >= this.array.Length)
            {
                this.Resize(this.array.Length * 2);
            }

            Array.Copy(this.array, index, this.array, index + 1, this.array.Length - 1 - index);

            this.array[index] = element;
            this.lastIndex++;
        }

        public void Clear()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                this.array[i] = default(T);
            }

            this.lastIndex = 0;
        }

        public int FindIndex(T value)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public override string ToString()
        {
            var result = this.array.Take(this.lastIndex);
            return string.Join(", ", result);
        }

        public T Min()
        {
            if (this.array.Length == 0)
            {
                throw new InvalidOperationException("System has no elements!");
            }

            if (this.array.Length == 1)
            {
                return this.array[0];
            }

            T min = this.array[0];

            for (int i = 1; i < this.lastIndex; i++)
            {
                if (min.CompareTo(this.array[i]) == 1)
                {
                    min = this.array[i];
                }
            }

            return min;
        }

        public T Max()
        {
            if (this.array.Length == 0)
            {
                throw new InvalidOperationException("System has no elements!");
            }

            if (this.array.Length == 1)
            {
                return this.array[0];
            }

            T max = this.array[0];

            for (int i = 1; i < this.lastIndex; i++)
            {
                if (max.CompareTo(this.array[i]) == -1)
                {
                    max = this.array[i];
                }
            }

            return max;
        }

        private void Resize(int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void ReArrange(int index)
        {
            for (int i = index; i < this.array.Length - 1; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
    }
}
