using System;
//Write a method that checks if the element at given position in a given array of integers is larger than its two neighbours (when such exist).
class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i == 0)
        {
            if (numbers[i] > numbers[i + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (i == numbers.Length - 1)
        {
            if (numbers[i] > numbers[i - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

