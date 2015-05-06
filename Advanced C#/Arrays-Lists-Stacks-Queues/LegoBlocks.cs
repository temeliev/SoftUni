using System;
using System.Linq;

//You are given two jagged arrays. Each array represents a Lego block containing integers. 
//Your task is first to reverse the second jagged array and then check if it would fit perfectly in the first jagged array. 
//The picture above shows exactly what fitting arrays mean. 
//If the arrays fit perfectly you should print out the newly made rectangular matrix. 
//If the arrays do not match (they do not form a rectangular matrix) you should print out the number of cells in the first array and in the second array combined. 
//The examples below should help you understand the assignment better.
class LegoBlocks
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] jaggedArray1 = new int[n][];
        int[][] jaggedArray2 = new int[n][];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            jaggedArray1[i] = Array.ConvertAll(input, int.Parse);
        }

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            jaggedArray2[i] = Array.ConvertAll(input, int.Parse);
        }

        for (int i = 0; i < n; i++)
        {
            jaggedArray1[i] = jaggedArray1[i].Concat(jaggedArray2[i].Reverse()).ToArray();
        }
        int length = jaggedArray1[0].Length;
        int totalLength = length;
        bool itFits = true;
        for (int i = 1; i < jaggedArray1.Length; i++)
        {
            int len = jaggedArray1[i].Length;
            totalLength += len;
            if (len != length)
            {
                itFits = false;
            }
        }

        if (itFits)
        {
            for (int i = 0; i < jaggedArray1.Length; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", jaggedArray1[i]));
            }
        }
        else
        {
            Console.WriteLine("The total number of cells is: {0}", totalLength);
        }
    }
}

