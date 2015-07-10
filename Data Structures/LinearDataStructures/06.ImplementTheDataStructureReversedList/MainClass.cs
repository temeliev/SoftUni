namespace _06.ImplementTheDataStructureReversedList
{
    using System;

    class MainClass
    {
        static void Main()
        {
            ReversedList<int> testList = new ReversedList<int>();
            testList.Add(5);
            testList.Add(15);
            testList.Add(25);
            testList.Add(35);
            testList.Add(45);
            testList.Add(55);
            testList.Remove(0);

            Console.WriteLine(string.Join(" ", testList));
        }
    }
}
