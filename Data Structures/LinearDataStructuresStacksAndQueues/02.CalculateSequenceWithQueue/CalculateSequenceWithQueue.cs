namespace _02.CalculateSequenceWithQueue
{
    using System;
    using System.Collections.Generic;

    class CalculateSequenceWithQueue
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int end = 50;
            Queue<int> result = new Queue<int>();
            result.Enqueue(n);

            while (end > 0)
            {
                int current = result.Dequeue();
                result.Enqueue(current + 1);
                result.Enqueue(2 * current + 1);
                result.Enqueue(current + 2);
                end--;
                if (end == 0)
                {
                    Console.WriteLine(current);
                }
                else
                {
                    Console.Write(current + ", ");
                }
            }
        }
    }
}
