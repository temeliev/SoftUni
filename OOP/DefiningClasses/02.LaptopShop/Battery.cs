using System;
using System.Linq;
using System.Text;

namespace _02.LaptopShop
{
    public class Battery
    {
        public Battery(string batteryDesc, double? lifeHours)
        {
            this.description = batteryDesc;
            this.LifeHours = lifeHours;
        }

        public Battery(string batteryDesc)
            : this(batteryDesc, null)
        {
        }

        public Battery(double lifeHours)
            : this(null, lifeHours)
        {
        }

        public string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (HasWhiteSpaces(value))
                {
                    throw new ArgumentNullException("Missing battery description!");
                }

                description = value;
            }
        }

        public double? lifeHours;
        public double? LifeHours
        {
            get { return lifeHours; }
            set
            {
                if (LifeHours != null && LifeHours < 0)
                {
                    throw new ArgumentException("Negative battery life hours!");
                }

                lifeHours = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Description != null)
            {
                sb.AppendLine("battery: " + this.Description);
            }

            if (LifeHours != null)
            {
                sb.AppendLine(String.Format("battery life: {0:f1} hours", LifeHours));
            }

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
