using System;
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1 if there's no such element. 
//Use the method from the previous exercise in order to re.
class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetFirstElementLargerThanNeighbours(sequenceThree));
    }

    private static int GetFirstElementLargerThanNeighbours(int[] sequence)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            if (IsLargerThanNeighbours(sequence, i))
            {
                return i;
            }
        }

        return -1;
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

