using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04.ArrayBasedStackUnitTests
{
    using _03.ImplementArray_BasedStack;

    [TestClass]
    public class ArrayStackTests
    {
        [TestMethod]
        public void PushPopTest()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            Assert.AreEqual(0, stack.Count, "Check current count if stack has zero elements");
            stack.Push(1);
            Assert.AreEqual(1, stack.Count, "Count of stack when Push element");
            int element = stack.Pop();
            Assert.AreEqual(0, stack.Count, "Count of stack when Pop element");
            Assert.AreEqual(1, element, "Checks if poped element is equal to 1");
        }

        [TestMethod]
        public void PushPop1000ElementsTest()
        {
            ArrayStack<string> stack = new ArrayStack<string>();
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
        public void PopEmptyStackTest()
        {
            ArrayStack<string> stack = new ArrayStack<string>();
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
        public void PushPopWithInitialCapacity1Test()
        {
            ArrayStack<int> stack = new ArrayStack<int>(1);
            Assert.AreEqual(0, stack.Count, "Check current count if stack has zero elements");
            stack.Push(1);
            Assert.AreEqual(1, stack.Count, "Count of stack when Push element");
            stack.Push(2);
            Assert.AreEqual(2, stack.Count, "Count of stack when Push element");
            int element = stack.Pop();
            Assert.AreEqual(2, element, "Checks if poped element is equal to 2");
            Assert.AreEqual(1, stack.Count, "Count of stack when Pop element");
            element = stack.Pop();
            Assert.AreEqual(1, element, "Checks if poped element is equal to 1");
            Assert.AreEqual(0, stack.Count, "Count of stack when Pop element");
        }

        [TestMethod]
        public void ToArrayTest()
        {
            ArrayStack<int> stack = new ArrayStack<int>();
            stack.Push(3);
            stack.Push(5);
            stack.Push(-2);
            stack.Push(7);
            var array = stack.ToArray();
            Assert.AreEqual("7, -2, 5, 3", string.Join(", ", array), "Checks if ToArray() is reversing correctly the elements");
        }

        [TestMethod]
        public void EmptyStackToArrayTest()
        {
            ArrayStack<DateTime> stack = new ArrayStack<DateTime>();
            var array = stack.ToArray();
            Assert.AreEqual("", string.Join(", ", array), "Checks if ToArray() is returning empty string result when the stack is empty");
        }
    }
}
