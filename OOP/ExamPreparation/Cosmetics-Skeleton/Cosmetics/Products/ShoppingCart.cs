namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Linq;

    using Cosmetics.Contracts;

    public class ShoppingCart : IShoppingCart
    {
        private List<IProduct> shoppingCart;

        public ShoppingCart()
        {
            this.shoppingCart = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            this.shoppingCart.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.shoppingCart.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.shoppingCart.Contains(product);
            //.Any(p => p.Name == product.Name
            //                          && p.Brand == product.Brand
            //                          && p.Price == product.Price
            //                          && p.Gender == product.Gender);
        }

        public decimal TotalPrice()
        {
            return this.shoppingCart.Sum(x => x.Price);
        }
    }
}
