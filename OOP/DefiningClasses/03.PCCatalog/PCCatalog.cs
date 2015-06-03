using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            List<Computer> computers = new List<Computer>();

            Computer pc1 = new Computer("HP", 200, new List<Component>()
            {
                new Component("Motherboard", 50),
                new Component("CPU", 150, "3200 GHz")
            });
            computers.Add(pc1);
            Computer pc2 = new Computer("Lenovo", 225, new List<Component>()
            {
                new Component("Motherboard", 90),
                new Component("CPU", 180, "3300 GHz"),
                new Component("RAM", 55, "8 GB")
            });
            computers.Add(pc2);

            Computer pc3 = new Computer("Acer", 219, new List<Component>()
            {
                new Component("Motherboard", 69),
                new Component("CPU", 80, "2200 GHz"),
                new Component("RAM", 75, "8 GB")
            });
            computers.Add(pc3);

            foreach (var comp in computers.OrderBy(x => x.price))
            {
                Console.WriteLine(comp);
            }
        }
    }
}
