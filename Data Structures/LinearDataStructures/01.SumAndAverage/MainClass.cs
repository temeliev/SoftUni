namespace _01.SumAndAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainClass
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
                Console.WriteLine("Sum={0}; Average={1}", numbers.Sum(), numbers.Average());
            }
            catch (FormatException)
            {
                Console.WriteLine("Sum=0; Average=0");
            }
        }
    }
}
