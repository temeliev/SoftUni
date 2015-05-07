using System;
//Write a method that reverses the digits of a given floating-point number.
class ReverseNumber
{
    static void Main()
    {
        double reversed = GetReversedNumber(double.Parse(Console.ReadLine()));
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double num)
    {
        string str = num.ToString();
        string result = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }
        return double.Parse(result);
    }
}

