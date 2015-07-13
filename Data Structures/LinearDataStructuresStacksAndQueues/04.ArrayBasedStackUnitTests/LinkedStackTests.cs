namespace _04.ArrayBasedStackUnitTests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using _05.LinkedStack;

    [TestClass]
    public class LinkedStackTests
    {
        [TestMethod]
        public void LinkedStackPushPopTest()
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            Assert.AreEqual(0, stack.Count, "Check current count if stack has zero elements");
            stack.Push(1);
            Assert.AreEqual(1, stack.Count, "Count of stack when Push element");
            int element = stack.Pop();
            Assert.AreEqual(0, stack.Count, "Count of stack when Pop element");
            Assert.AreEqual(1, element, "Checks if poped element is equal to 1");
        }

        [TestMethod]
        public void LinkedStackPushPop1000ElementsTest()
        {
            LinkedStack<string> stack = new LinkedStack<string>();
            Assert.AreEqual(0, stack.Count);

            for (int i = 1; i <= 1000; i++)
            {
                stack.Push(i.ToString());
                Assert.AreEqual(i, stack.Count, "Count of stack when Push element");
            }

            for (int i = 1000; i > 0; i--)
            {
                string element = stack.Pop();
                Assert.AreEqual(i.ToString(), element, "Checks if poped element is equal to i value");
                Assert.AreEqual(i - 1, stack.Count, "Count of stack when Pop element");
            }
        }

        [TestMethod]
        public void PopEmptyLinkedStackTest()
        {
            LinkedStack<string> stack = new LinkedStack<string>();
            try
            {
                stack.Pop();
                Assert.Fail("Exception has not been thrown");
            }
            catch (Exception)
            {

            }
        }

        [TestMethod]
        public void LinkedStackToArrayTest()
        {
            LinkedStack<int> stack = new LinkedStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);
            var array = stack.ToArray();
            Assert.AreEqual("7, -2, 5, 3", string.Join(", ", array), "Checks if ToArray() is reversing correctly the elements");
        }

        [TestMethod]
        public void EmptyLinkedStackToArrayTest()
        {
            LinkedStack<DateTime> stack = new LinkedStack<DateTime>();
            var array = stack.ToArray();
            Assert.AreEqual("", string.Join(", ", array), "Checks if ToArray() is returning empty string result when the stack is empty");
        }
    }
}
