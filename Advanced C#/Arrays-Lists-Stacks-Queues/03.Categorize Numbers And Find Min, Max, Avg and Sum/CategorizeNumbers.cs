using System;
using System.Collections.Generic;
using System.Linq;
//Write a program that reads N floating-point numbers from the console. 
//Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) and the other containing the floating-point numbers with non-zero fraction. 
//Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 
class CategorizeNumbers
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        List<int> integers = new List<int>();
        List<double> doubles = new List<double>();

        for (int i = 0; i < input.Length; i++)
        {
            double dd = double.Parse(input[i]);
            if (dd % 1 == 0)
            {
                integers.Add(Convert.ToInt32(dd));
            }
            else
            {
                doubles.Add(dd);
            }

        }

        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", doubles), doubles.Min(), doubles.Max(), doubles.Sum(), doubles.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}", string.Join(", ", integers), integers.Min(), integers.Max(), integers.Sum(), integers.Average());
    }
}

