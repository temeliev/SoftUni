namespace _07.LinkedQueue
{
    using System;

    public class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = new QueueNode<T>(element);
                this.tail = this.head;
            }
            else
            {
                var newNode = new QueueNode<T>(element);
                if (this.Count == 1)
                {
                    this.tail = newNode;
                    this.head.NextNode = this.tail;
                    this.tail.PrevNode = this.head;
                }
                else
                {
                    newNode.PrevNode = this.tail;
                    this.tail.NextNode = newNode;
                    this.tail = newNode;
                }
                
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;
            this.Count--;

            return firstElement;
        }

        public T[] ToArray()
        {
            var newArray = new T[this.Count];
            var node = this.head;

            for (int i = 0; i < this.Count; i++)
            {
                newArray[i] = node.Value;
                node = node.NextNode;
            }

            return newArray;
        }

        private class QueueNode<T>
        {
            public QueueNode(T value)
            {
                this.Value = value;
            }

            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }
        }
    }
}
