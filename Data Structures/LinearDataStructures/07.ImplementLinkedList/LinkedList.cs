namespace _07.ImplementLinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
    {
        private ListNode<T> head;

        private ListNode<T> tail;

        public int Count { get; private set; }

        public void Add(T element)
        {
            if (this.Count == 0)
            {
                this.head = new ListNode<T>(element);
                this.head.NextNode = null;
                this.tail = this.head;
            }
            else
            {
                var newHead = new ListNode<T>(element);
                newHead.NextNode = null;
                this.tail.NextNode = newHead;
                this.tail = newHead;
            }

            this.Count++;
        }

        public T Remove(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            if (index < 0 || index > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException("Index is out of range");
            }

            int currentIndex = 0;
            ListNode<T> currNode = this.head;
            ListNode<T> prevNode = null;

            while (currentIndex < index)
            {
                prevNode = currNode;
                currNode = currNode.NextNode;
                currentIndex++;
            }

            this.Count--;

            if (this.Count == 0)
            {
                this.head = null;
                this.tail = this.head;
            }
            else if (prevNode == null)
            {
                this.head = currNode.NextNode;
                this.tail = this.head;
            }
            else
            {
                prevNode.NextNode = currNode.NextNode;

                if (prevNode.NextNode == null)
                {
                    this.tail = prevNode;
                }
            }

            return currNode.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.head;

            while (currentNode != null)
            {
                yield return currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int FirstIndexOf(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            ListNode<T> currNode = this.head;

            int index = 0;

            while (index < this.Count)
            {
                if (currNode.Value.Equals(element))
                {
                    return index;
                }

                currNode = currNode.NextNode;
                index++;
            }

            return -1;
        }

        public int LastIndexOf(T element)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }

            ListNode<T> currNode = this.head;

            int index = 0;
            int lastFoundIndex = -1;

            while (index < this.Count)
            {
                if (currNode.Value.Equals(element))
                {
                    lastFoundIndex = index;
                }

                currNode = currNode.NextNode;
                index++;
            }

            return lastFoundIndex;
        }

        private class ListNode<TP>
        {
            public ListNode(TP value)
            {
                this.Value = value;
            }

            public TP Value { get; private set; }

            public ListNode<TP> NextNode { get; set; }
        }
    }
}
