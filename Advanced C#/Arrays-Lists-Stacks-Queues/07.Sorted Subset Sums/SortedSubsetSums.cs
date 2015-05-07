using System;
using System.Collections.Generic;
using System.Linq;

//Modify the program you wrote for the previous problem to print the results in the following way: each line should contain the operands (numbers that form the desired sum) in ascending order; 
//the lines containing fewer operands should be printed before those with more operands; 
//when two lines have the same number of operands, the one containing the smallest operand should be printed first. 
//If two or more lines contain the same number of operands and have the same smallest operand, the order of printing is not important.
class SortedSubsetSums
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        Dictionary<string, int> result = new Dictionary<string, int>();
        for (int i = 0; i < Math.Pow(2, input.Length); i++) //n^2 all posible subsets
        {
            List<int> combinations = new List<int>();
            for (int j = 0; j < input.Length; j++)
            {
                if ((i & (1 << (input.Length - j - 1))) != 0)
                {
                    combinations.Add(int.Parse(input[j]));
                }
            }
            if (combinations.Count > 0)
            {
                if (combinations.Sum() == n)
                {
                    string str = string.Join(" ", combinations.OrderBy(x => x));
                    if (!result.ContainsKey(str))
                    {
                        result[str] = combinations.Count;
                    }
                }
            }
        }

        if (result.Count > 0)
        {
            var order = result.OrderBy(x => x.Value).ThenBy(x => x.Key).Select(x => x.Key).ToList();
            foreach (var item in order)
            {
                var res = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine("{0} = {1}", string.Join(" + ", res), n);
            }
        }
        else
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

