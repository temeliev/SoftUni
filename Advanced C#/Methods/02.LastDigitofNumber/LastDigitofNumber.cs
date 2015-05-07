using System;
//Write a method that returns the last digit of a given integer as an English word. 
//Test the method with different input values. Ensure you name the method properly
class LastDigitofNumber
{
    static void Main()
    {
        Console.WriteLine(GetLastDigitAsWord(512));
        Console.WriteLine(GetLastDigitAsWord(1024));
        Console.WriteLine(GetLastDigitAsWord(12309));
    }

    private static string GetLastDigitAsWord(int digit)
    {
        string num = digit.ToString();

        switch (num[num.Length - 1])
        {
            case '0':
                return "zero";
            case '1':
                return "one";
            case '2':
                return "two";
            case '3':
                return "three";
            case '4':
                return "four";
            case '5':
                return "five";
            case '6':
                return "six";
            case '7':
                return "seven";
            case '8':
                return "eight";
            case '9':
                return "nine";
            default:
                return "";
        }
    }
}

