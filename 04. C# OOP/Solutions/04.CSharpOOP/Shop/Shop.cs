namespace Shop
{
    using System.Collections.Generic;

    public class Shop
    {
        private List<Product> products;

        public Shop()
        {
            this.products = new List<Product>();
        }

        public int Count => this.products.Count;

        public void Add(Product product)
        {
            this.products.Add(product);
        }

        public void Buy(Product product)
        {
            this.products.Remove(product);
        }
    }
}
