using System;
using System.Collections.Generic;

//George likes math. Recently he discovered an interesting property of the Pythagorean Theorem: 
//there are infinite number of triplets of integers a, b and c (a ≤ b), such that a2 + b2 = c2. 
//Write a program to help George find all such triplets (called Pythagorean numbers) among a set of integer numbers.
class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        List<int> squares = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            numbers.Add(num);
            squares.Add(num * num);
        }
        int count = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = 0; j < numbers.Count; j++)
            {
                int a = numbers[i];
                int b = numbers[j];
                int sqrt = a * a + b * b;
                if (a <= b && squares.Contains(sqrt))
                {
                    double c = Math.Sqrt(sqrt);
                    Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                    count++;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
