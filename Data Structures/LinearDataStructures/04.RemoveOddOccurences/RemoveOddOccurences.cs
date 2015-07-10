namespace _04.RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;

    public class RemoveOddOccurences
    {
        static void Main()
        {
            List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int count = 0;
                int current = numbers[i];

                for (int i1 = 0; i1 < numbers.Count; i1++)
                {
                    if (current == numbers[i1])
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    result.Add(current);
                }
            }

            numbers.RemoveAll(x => result.Contains(x));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
