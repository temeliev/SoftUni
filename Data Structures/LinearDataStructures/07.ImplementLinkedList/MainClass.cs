namespace _07.ImplementLinkedList
{
    using System;

    class MainClass
    {
        static void Main()
        {
            LinkedList<int> test = new LinkedList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(5);
            test.Add(22);
            test.Add(15);
            test.Add(22);
            test.Add(35);
            test.Remove(1);

            foreach (var t in test)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(" ", test));
        }
    }
}
