namespace _04.ArrayBasedStackUnitTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using _07.LinkedQueue;

    [TestClass]
    public class LinkedQueueTests
    {
        [TestMethod]
        public void LinkedQueueEnqueueDequeueTest()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            Assert.AreEqual(0, queue.Count, "Check current count if queue has zero elements");
            queue.Enqueue(1);
            Assert.AreEqual(1, queue.Count, "Count of queue when Enqueue element");
            int element = queue.Dequeue();
            Assert.AreEqual(0, queue.Count, "Count of queue when Dequeue element");
            Assert.AreEqual(1, element, "Checks if Dequeue element is equal to 1");
        }

        [TestMethod]
        public void LinkedQueuePushPop1000ElementsTest()
        {
            LinkedQueue<string> queue = new LinkedQueue<string>();
            Assert.AreEqual(0, queue.Count);

            for (int i = 1; i <= 1000; i++)
            {
                queue.Enqueue(i.ToString());
                Assert.AreEqual(i, queue.Count, "Count of queue when Enqueue element");
            }

            for (int i = 1; i <= 1000; i++)
            {
                string element = queue.Dequeue();
                Assert.AreEqual(i.ToString(), element, "Checks if dequeued element is equal to i value");
                Assert.AreEqual(1000 - i, queue.Count, "Count of queue when Dequeue element");
            }
        }

        [TestMethod]
        public void DequeueEmptyLinkedQueueTest()
        {
            LinkedQueue<string> queue = new LinkedQueue<string>();
            try
            {
                queue.Dequeue();
                Assert.Fail("Exception has not been thrown");
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void LinkedQueueToArrayTest()
        {
            LinkedQueue<int> queue = new LinkedQueue<int>();
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(-2);
            queue.Enqueue(7);
            var array = queue.ToArray();
            Assert.AreEqual(
                "3, 5, -2, 7",
                string.Join(", ", array),
                "Checks if ToArray() is converting correctly the elements");
        }

        [TestMethod]
        public void EmptyLinkedQueueToArrayTest()
        {
            LinkedQueue<DateTime> queue = new LinkedQueue<DateTime>();
            var array = queue.ToArray();
            Assert.AreEqual(
                "",
                string.Join(", ", array),
                "Checks if ToArray() is returning empty string result when the queue is empty");
        }
    }
}
