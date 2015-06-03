using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop laptop = new Laptop(
                "Lenovo Yoga 2 Pro",
                2259M, "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                "8 GB",
                "128GB SSD",
                "Intel HD Graphics 4400",
                @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5));

            Console.WriteLine(laptop);

            Laptop laptop2 = new Laptop(
                "HP 250 G2",
                699M);
            Console.WriteLine(laptop2);
        }
    }
}
