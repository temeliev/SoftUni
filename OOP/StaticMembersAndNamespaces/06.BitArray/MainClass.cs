using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BitArray
{
    class MainClass
    {
        static void Main()
        {
            BitArray arr = new BitArray(10);
            arr[0] = 1;
            arr[1] = 1;
            arr[9] = 1;

            Console.WriteLine("The number is {0}", arr);
            Console.WriteLine("Byte at position 9: {0}", arr[9]);
        }
    }
}
