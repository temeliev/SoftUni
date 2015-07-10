namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.IsVegan)
            {
                sb.Append("[VEGAN] ");
            }

            sb.Append(base.ToString());
            sb.AppendFormat("Contains pasta: {0}", this.ContainsPasta ? "yes" : "no").AppendLine();

            return sb.ToString();
        }
    }
}
