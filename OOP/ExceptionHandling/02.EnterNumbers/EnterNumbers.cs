using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
    //If an invalid number or non-number text is entered, the method should throw an exception. 
    //Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
    //If the user enters an invalid number, let the user to enter again.
    class EnterNumbers
    {
        static void Main()
        {
            int start = 1;
            int end = 100;
            List<int> numbers = new List<int>();

            while (numbers.Count < 10)
            {
                try
                {
                    numbers.Add(ReadNumber(start, end));
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                    Console.WriteLine("Please enter another number!");
                }
                catch (ArgumentOutOfRangeException ar)
                {
                    Console.WriteLine(ar.Message);
                    Console.WriteLine("Please enter another number!");
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int num = int.MinValue;
            bool isNum = int.TryParse(input, out num);

            if (!isNum)
            {
                throw new FormatException(@"The entered data is not a number!");
            }

            if (num < 0 || num > end || num < start)
            {
                throw new ArgumentOutOfRangeException(@"The number has to be in range [1...100]");
            }

            return num;
        }
    }
}
