namespace RestaurantManager.Models
{
    using RestaurantManager.Interfaces;

    public abstract class Meal : Recipe, IMeal
    {
        protected Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.Unit = MetricUnit.Grams;
            this.IsVegan = isVegan;
        }

        public bool IsVegan { get; private set; }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }
    }
}
