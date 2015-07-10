using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using _06.ImplementTheDataStructureReversedList;

    [TestClass]
    public class ReversedListTests
    {
        [TestMethod]
        public void TestReversedListCapacity()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);

            Assert.AreEqual(8, testList.Capacity);
        }

        [TestMethod]
        public void TestReversedListCount()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);
            testList.Remove(0);

            Assert.AreEqual(5, testList.Count);
        }

        [TestMethod]
        public void TestReversedListAdd()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);

            Assert.AreEqual("55 45 35 25 15 5", string.Join(" ", testList));
        }

        [TestMethod]
        public void TestReversedListRemove()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);
            testList.Remove(5);

            Assert.AreEqual("55 45 35 25 15", string.Join(" ", testList));
        }

        [TestMethod]
        public void TestReversedListIndexator()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);
            testList[0] = 100;
            testList[1] = 300;
            int num = testList[0];
            testList.Remove(5);

            Assert.AreEqual(100, testList[0]);
            Assert.AreEqual(100, num);
            Assert.AreEqual(15, testList[4]);
        }
    }
}
