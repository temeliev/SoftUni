namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;

        private readonly IList<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredientsList = ingredients;
        }

        public string Ingredients
        {
            get
            {
                if (this.ingredients == null)
                {
                    foreach (var ingredient in this.ingredientsList)
                    {
                        if (ingredient.Length < 4 || ingredient.Length > 12)
                        {
                            throw new ArgumentException(String.Format("Each ingredient must be between {0} and {1} symbols long!", 4, 12));
                        }
                    }

                    this.ingredients = String.Join(", ", this.ingredientsList);
                }

                return this.ingredients;
            }

            //private set
            //{
            //    Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredients"));

            //    this.CheckIngredients(value);

            //    this.ingredients = value;
            //}
        }

        private void CheckIngredients(string value)
        {
            string[] input = value.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var val in input)
            {
                if (val.Length < 4 || val.Length > 12)
                {
                    throw new ArgumentException(String.Format("Each ingredient must be between {0} and {1} symbols long!", 4, 12));
                }
            }
        }

        public override string ToString()
        {
            StringBuilder paste = new StringBuilder(base.Print());
            paste.AppendFormat("  * Ingredients: {0}", this.Ingredients);

            return paste.ToString();
        }
    }
}
