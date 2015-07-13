namespace _01.ReverseNumbersWithStack
{
    using System;
    using System.Collections.Generic;

    class ReverseNumbersWithStack
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            int num;
            if (input.Length > 0 && int.TryParse(input[0], out num))
            {
                Stack<int> numbers = new Stack<int>();

                foreach (var i in input)
                {
                    numbers.Push(int.Parse(i));
                }

                while (numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Pop() + " ");
                }
            }
            else
            {
                Console.WriteLine(string.Join("", input));
            }
        }
    }
}
