using System;
//Write a program to sort an array of numbers and then print them back on the console. 
//The numbers should be entered from the console on a single line, separated by a space. Refer to the examples for problem 1.
//Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
class SelectionSort
{
    static void Main()
    {
        var stringArray = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);
        SelectSort(numbers);
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }

    public static void SelectSort(int[] array)
    {
        int index = 0;
        for (int a = 0; a < array.Length; a++)
        {
            int currentMin = array[a];
            for (int b = a + 1; b < array.Length; b++)
            {
                if (currentMin > array[b])
                {
                    currentMin = array[b];
                    index = b;
                }
            }

            if (currentMin != array[a])
            {
                int temp = array[a];
                array[a] = currentMin;
                array[index] = temp;
            }
        }
    }
}

