using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            StupidList<int> test = new StupidList<int>();
            for (int i = 0; i < 10; i++)
            {
                test.Add(i);
            }

            test.Remove(9);
        }
    }
}
