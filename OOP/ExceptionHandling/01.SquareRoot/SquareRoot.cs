using System;
//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". 
//In all cases finally print "Good bye". Use try-catch-finally.
namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double root = Math.Sqrt(num);
                Console.WriteLine(root);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
