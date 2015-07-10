namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequence
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            List<int> result = GetLongestSequence(input);
            Console.WriteLine("{0}", string.Join(" ", result));
        }

        public static List<int> GetLongestSequence(string[] input)
        {
            List<int> numbers = new List<int>(Array.ConvertAll(input, int.Parse));
            List<int> currentList = new List<int>();
            List<int> longestList = new List<int>();

            int prev = numbers[0];
            int current;
            int index = 1;

            if (numbers.Count > 1)
            {
                while (index < numbers.Count)
                {
                    current = numbers[index];

                    if (prev == current)
                    {
                        currentList.Add(prev);
                    }
                    else
                    {
                        currentList.Add(prev);

                        if (currentList.Count > longestList.Count)
                        {
                            longestList.Clear();
                            longestList.AddRange(currentList);
                        }

                        currentList.Clear();
                    }

                    if (index == numbers.Count - 1 && currentList.Count > 0)
                    {
                        currentList.Add(current);

                        if (currentList.Count > longestList.Count)
                        {
                            longestList.Clear();
                            longestList.AddRange(currentList);
                        }
                    }

                    prev = current;
                    index++;
                }

                return longestList;
            }

            return numbers;
        }
    }
}
