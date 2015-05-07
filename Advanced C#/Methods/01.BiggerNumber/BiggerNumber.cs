﻿using System;
//Write a method GetMax() with two parameters that returns the larger of two integers. 
//Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            return firstNumber;
        }
        else
        {
            return secondNumber;
        }
    }
}

