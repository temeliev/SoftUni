namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private string name;

        private List<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Category name"));
                Validator.CheckIfStringLengthIsValid(value, 15, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            StringBuilder category = new StringBuilder();
            string prod = this.products.Count != 1 ? "products" : "product";
            if (this.products.Count == 0)
            {
                category.Append(string.Format(
                    "{0} category - {1} {2} in total",
                    this.Name,
                    this.products.Count,
                    prod));
            }
            else
            {
                category.AppendLine(string.Format(
                    "{0} category - {1} {2} in total",
                    this.Name,
                    this.products.Count,
                    prod));

                int count = 1;
                foreach (IProduct product in this.products.OrderBy(s => s.Brand).ThenByDescending(s => s.Price))
                {
                    if (product is Toothpaste)
                    {
                        var tooth = (Toothpaste)product;
                        //category.Append(tooth.ToString());
                        if (count == this.products.Count)
                        {
                            category.Append(tooth.ToString());
                        }
                        else
                        {
                            category.AppendLine(tooth.ToString());
                        }
                    }
                    else if (product is Shampoo)
                    {
                        var shampoo = (Shampoo)product;
                        category.Append(shampoo.ToString());
                    }
                    count++;
                    //category.AppendLine().Append(product.Print());
                }
            }

            return category.ToString();
            //StringBuilder sb = new StringBuilder();
            //string prod = this.products.Count != 1 ? "products" : "product";
            //if (this.products.Count == 0)
            //{
            //    sb.Append(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, prod));
            //}
            //else
            //{
            //    int count = 1;
            //    sb.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, prod));

            //    foreach (var product in this.products.OrderBy(x => x.Brand).ThenByDescending(x => x.Price))
            //    {
            //        sb.AppendLine(string.Format("- {0} - {1}:", product.Brand, product.Name));
            //        sb.AppendLine(string.Format("  * Price: ${0}", product.Price));
            //        sb.AppendLine(string.Format("  * For gender: {0}", product.Gender));

            //        if (product is Toothpaste)
            //        {
            //            var tooth = (Toothpaste)product;
            //            if (count == this.products.Count)
            //            {
            //                sb.Append(string.Format("  * Ingredients: {0}", tooth.Ingredients));
            //            }
            //            else
            //            {
            //                sb.AppendLine(string.Format("  * Ingredients: {0}", tooth.Ingredients));
            //            }
            //        }
            //        else if (product is Shampoo)
            //        {
            //            var shampoo = (Shampoo)product;
            //            sb.AppendLine(string.Format("  * Quantity: {0} ml", shampoo.Milliliters));
            //            sb.Append(string.Format("  * Usage: {0}", shampoo.Usage));
            //        }
            //        count++;
            //    }
            //}

            //return sb.ToString();
        }
    }
}
