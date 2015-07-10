namespace _05.CountOfOccurences
{
    using System;
    using System.Collections.Generic;

    class CountOfOccurences
    {
        static void Main()
        {
            List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!result.ContainsKey(numbers[i]))
                {
                    result[numbers[i]] = 1;
                }
                else
                {
                    result[numbers[i]]++;
                }
            }

            foreach (var r in result)
            {
                Console.WriteLine("{0} -> {1} times", r.Key, r.Value);
            }
        }
    }
}
