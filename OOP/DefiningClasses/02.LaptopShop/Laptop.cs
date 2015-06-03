using System;
using System.Linq;
using System.Text;

namespace _02.LaptopShop
{
    public class Laptop
    {
        public Laptop(string model, decimal price, string manufacturer, string proccesor, string ram, string hdd, string graphicCard, string screen, Battery battery)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Proccesor = proccesor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.GraphicCard = graphicCard;
            this.Screen = screen;
            this.Battery = battery;
        }

        public Laptop(string model, decimal price, string manufacturer, string proccesor, string ram, string hdd,
            string graphicCard, string screen)
            : this(model, price, manufacturer, proccesor, ram, hdd, graphicCard, screen, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer, string proccesor, string ram, string hdd,
            string graphicCard)
            : this(model, price, manufacturer, proccesor, ram, hdd, graphicCard, null, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer, string proccesor, string ram, string hdd)
            : this(model, price, manufacturer, proccesor, ram, hdd, null, null, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer, string proccesor, string ram)
            : this(model, price, manufacturer, proccesor, ram, null, null, null, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer, string proccesor)
            : this(model, price, manufacturer, proccesor, null, null, null, null, null)
        {
        }

        public Laptop(string model, decimal price, string manufacturer)
            : this(model, price, manufacturer, null, null, null, null, null, null)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, price, null, null, null, null, null, null, null)
        {
        }


        public string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentNullException("Missing model!");
                }
            }
        }

        public string manufacturer;
        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    manufacturer = value;
                }
                else
                {
                    throw new ArgumentException("Missing manufacturer!");
                }
            }
        }

        public string proccesor;
        public string Proccesor
        {
            get { return proccesor; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    proccesor = value;
                }
                else
                {
                    throw new ArgumentException("Missing proccesor description!");
                }
            }
        }

        public string ram;
        public string Ram
        {
            get { return ram; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    ram = value;
                }
                else
                {
                    throw new ArgumentException("Missing RAM description!");
                }
            }
        }

        public string graphicCard;
        public string GraphicCard
        {
            get { return graphicCard; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    graphicCard = value;
                }
                else
                {
                    throw new ArgumentException("Missing graphic card description!");
                }
            }
        }

        public string hdd;
        public string Hdd
        {
            get { return hdd; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    hdd = value;
                }
                else
                {
                    throw new ArgumentException("Missing hdd description!");
                }
            }
        }

        public string screen;
        public string Screen
        {
            get { return screen; }
            set
            {
                if (!HasWhiteSpaces(value))
                {
                    screen = value;
                }
                else
                {
                    throw new ArgumentException("Missing screen description!");
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


        public Battery Battery { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("model: " + this.Model);
            if (this.Manufacturer != null)
            {
                sb.AppendLine("manufacturer: " + this.Manufacturer);
            }

            if (this.Proccesor != null)
            {
                sb.AppendLine("proccesor: " + this.Proccesor);
            }

            if (this.Ram != null)
            {
                sb.AppendLine("RAM: " + this.Ram);
            }

            if (this.GraphicCard != null)
            {
                sb.AppendLine("graphics card: " + this.GraphicCard);
            }

            if (this.Hdd != null)
            {
                sb.AppendLine("HDD: " + this.Hdd);
            }

            if (this.Screen != null)
            {
                sb.AppendLine("screen: " + this.Screen);
            }

            if(Battery!=null)
            { 
            string batteryInfo = Battery.ToString();
            if (batteryInfo.Length > 0)
            {
                sb.Append(batteryInfo);
            }
}

            sb.AppendLine(String.Format("price: {0:f2} lv.", this.Price));

            return sb.ToString();
        }

        private static bool HasWhiteSpaces(string value)
        {
            if (value != null)
            {
                if (value.Count(x => x == ' ') == value.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
