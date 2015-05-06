using System;
using System.Collections.Generic;

//You are given n numbers. 
//Write a program to find among these numbers all sets of 4 numbers {a, b, c, d}, such that a|b == c|d, where a ≠ b ≠ c ≠ d.
//Assume that "a|b" means to append the number b after a. We call these numbers {a, b, c, d} stuck numbers:
//if we append a and b, we get the same result as if we appended c and d. Note that the numbers a, b, c and d should be distinct (a ≠ b ≠ c ≠ d).
class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Trim().Split();
        int[] nums = Array.ConvertAll(input, int.Parse);

        List<string> output = new List<string>();

        for (int num1 = 0; num1 < nums.Length; num1++)
        {
            for (int num2 = 0; num2 < nums.Length; num2++)
            {
                for (int num3 = 0; num3 < nums.Length; num3++)
                {
                    for (int num4 = 0; num4 < nums.Length; num4++)
                    {
                        int a = nums[num1];
                        int b = nums[num2];
                        int c = nums[num3];
                        int d = nums[num4];

                        if (a != b && a != c && a != d &&
                            b != c && b != d && c != d)
                        {
                            String first = a + "" + b;
                            String second = c + "" + d;
                            if (first == second)
                            {
                                output.Add(string.Format("{0}|{1}=={2}|{3}", a, b, c, d));
                            }
                        }
                    }
                }
            }
        }

        if (output.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            output.ForEach(o => Console.WriteLine(o));
        }
    }
}

