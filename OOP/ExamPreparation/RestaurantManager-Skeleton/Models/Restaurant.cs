namespace RestaurantManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Restaurant : IRestaurant
    {
        private string name;

        private string location;

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name is required.");
                }

                this.name = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The location is required.");
                }

                this.location = value;
            }
        }

        public IList<IRecipe> Recipes { get; private set; }


        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("***** {0} - {1} *****", this.Name, this.Location).AppendLine();
            if (this.Recipes.Count == 0)
            {
                sb.Append("No recipes... yet");
            }
            else
            {
                var drinks = this.Recipes.Where(x => x is Drink).OrderBy(x => x.Name).Cast<Drink>();
                if (drinks.Any())
                {
                    sb.AppendLine("~~~~~ DRINKS ~~~~~");
                    foreach (Drink drink in drinks)
                    {
                        sb.Append(drink);
                    }
                }

                var salads = this.Recipes.Where(x => x is Salad).OrderBy(x => x.Name).Cast<Salad>();
                if (salads.Any())
                {
                    sb.AppendLine("~~~~~ SALADS ~~~~~");
                    foreach (Salad salat in salads)
                    {
                        sb.Append(salat);
                    }
                }

                var courses = this.Recipes.Where(x => x is MainCourse).OrderBy(x => x.Name).Cast<MainCourse>();
                if (courses.Any())
                {
                    sb.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                    foreach (MainCourse main in courses)
                    {
                        sb.Append(main);
                    }
                }

                var desserts = this.Recipes.Where(x => x is Dessert).OrderBy(x => x.Name).Cast<Dessert>();
                if (desserts.Any())
                {
                    sb.AppendLine("~~~~~ DESSERTS ~~~~~");
                    foreach (Dessert des in desserts)
                    {
                        sb.Append(des);
                    }
                }
            }

            return sb.ToString().TrimEnd('\n');
        }
    }
}
