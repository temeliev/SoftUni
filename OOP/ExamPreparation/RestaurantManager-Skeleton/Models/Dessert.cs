namespace RestaurantManager.Models
{
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = true;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (!this.WithSugar)
            {
                sb.Append("[NO SUGAR] ");
            }

            if (this.IsVegan)
            {
                sb.Append("[VEGAN] ");
            }

            sb.Append(base.ToString());

            return sb.ToString();
        }
    }
}
