using System;

namespace _03.GenericList
{
    class MainClass
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>(7);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Remove(2);
            testList.Insert(1, 5);
            testList.Insert(100, 4);
            testList.Insert(101, 4);
            testList.Remove(1);
            Console.WriteLine(testList.FindIndex(1));
            Console.WriteLine(testList.Contains(101));
            Console.WriteLine(testList.Contains(201));
            Console.WriteLine(testList[2]);
            Console.WriteLine(testList);
            Console.WriteLine("Max: {0}", testList.Max());
            Console.WriteLine("Min: {0}", testList.Min());
            testList.Clear();
            Console.WriteLine(testList);
        }
    }
}
