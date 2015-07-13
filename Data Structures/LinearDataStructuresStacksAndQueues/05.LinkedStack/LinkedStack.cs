namespace _05.LinkedStack
{
    using System;

    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            this.Count--;
            var firstElement = this.firstNode;
            this.firstNode = this.firstNode.NextNode;

            return firstElement.Value;
        }

        public T[] ToArray()
        {
            var newArray = new T[this.Count];
            int index = 0;
            var node = this.firstNode;

            for (int i = this.Count - 1; i >= 0; i--)
            {
                newArray[index++] = node.Value;
                node = node.NextNode;
            }

            return newArray;
        }

        private class Node<TP>
        {
            public Node(TP value, Node<TP> next = null)
            {
                this.Value = value;
                this.NextNode = next;
            }

            public TP Value { get; private set; }
            public Node<TP> NextNode { get; set; }
        }
    }
}
