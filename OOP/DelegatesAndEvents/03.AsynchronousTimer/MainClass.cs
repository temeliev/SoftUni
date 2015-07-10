using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    class MainClass
    {
        private static int count = 1;

        static void Main()
        {
            int ticks = 10;
            int timeInterval = 2000;

            AsyncTimer timer = new AsyncTimer(PrintMethod, ticks, timeInterval);
            timer.Start();

            while (timer.IsCounting)
            {
                Console.ReadLine();
            }
        }

        private static void PrintMethod()
        {
            Console.WriteLine("I'm an AsyncTimer! Count: {0}", count++);
        }
    }
}
