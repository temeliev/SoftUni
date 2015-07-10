using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    using _07.ImplementLinkedList;

    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestLinkedListCount()
        {
            LinkedList<int> testList = new LinkedList<int>();
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
        public void TestLinkedListAdd()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);

            Assert.AreEqual("5 15 25 35 45 55", string.Join(" ", testList));
        }

        [TestMethod]
        public void TestLinkedListRemove()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);
            testList.Remove(0);

            Assert.AreEqual("15 25 35 45 55", string.Join(" ", testList));
            testList.Remove(4);
            Assert.AreEqual("15 25 35 45", string.Join(" ", testList));
        }

        [TestMethod]
        public void TestLinkedListFirstIndexOf()
        {
            LinkedList<int> testList = new LinkedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);

            int firstIndex = testList.FirstIndexOf(5);
            Assert.AreEqual(0, firstIndex);
            firstIndex = testList.FirstIndexOf(100);
            Assert.AreEqual(-1, firstIndex);
            firstIndex = testList.FirstIndexOf(45);
            Assert.AreEqual(4, firstIndex);
        }

        [TestMethod]
        public void TestLinkedListLastIndexOf()
        {
            LinkedList<int> testList = new LinkedList<int>();
            
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(5);

            int lastIndex = testList.LastIndexOf(5);
            Assert.AreEqual(5, lastIndex);
            lastIndex = testList.LastIndexOf(100);
            Assert.AreEqual(-1, lastIndex);
            lastIndex = testList.LastIndexOf(45);
            Assert.AreEqual(4, lastIndex);

            testList.Remove(5);
            lastIndex = testList.LastIndexOf(5);
            Assert.AreEqual(0, lastIndex);
        }
    }
}
