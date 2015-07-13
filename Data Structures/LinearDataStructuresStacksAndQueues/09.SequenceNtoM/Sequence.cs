namespace _09.SequenceNtoM
{
    using System;
    using System.Collections.Generic;

    class Sequence
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            int startNum = int.Parse(input[0]);
            int endNum = int.Parse(input[1]);
            Queue<Item> queue = new Queue<Item>();
            queue.Enqueue(new Item(startNum, null));

            while (queue.Count > 0)
            {
                var currentItem = queue.Dequeue();

                if (currentItem.Value < endNum)
                {
                    queue.Enqueue(new Item(currentItem.Value * 2, currentItem));
                    queue.Enqueue(new Item(currentItem.Value + 2, currentItem));
                    queue.Enqueue(new Item(currentItem.Value + 1, currentItem));
                }

                if (currentItem.Value == endNum)
                {
                    PrintResult(currentItem);
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("(no solution)");
            }
        }

        private static void PrintResult(Item item)
        {
            Stack<int> stack = new Stack<int>();

            while (item.NextItem != null)
            {
                stack.Push(item.Value);
                item = item.NextItem;

                if (item.NextItem == null)
                {
                    stack.Push(item.Value);
                }
            }

            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
