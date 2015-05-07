using System;
//Write a program to sort an array of numbers and then print them back on the console. 
//The numbers should be entered from the console on a single line, separated by a space.
class SortArrayOfNumbers
{
    static void Main()
    {
        var stringArray = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(stringArray, int.Parse);
        Array.Sort(numbers);
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
}

