using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.PCCatalog
{
    public class Computer
    {
        public Computer(string name, decimal price, List<Component> components)
        {
            this.Name = name;
            this.Price = price;
            this.Components = components;
        }

        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentNullException("Missing name!");
                }
            }
        }

        public decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Negative price!");
                }
            }
        }

        List<Component> Components { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + this.Name);
            this.Components.ForEach(
                x => sb.AppendLine(string.Format("Component: {0}   Price: {1}", x.Name, x.Price)));
            sb.AppendLine("Total price: " + this.Components.Sum(x => x.Price));

            return sb.ToString();
        }
    }
}
