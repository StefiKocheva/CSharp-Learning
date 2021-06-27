namespace Shop
{
    public class Product
    {
        public Product(string title, decimal price)
        {
            this.Title = title;
            this.Price = price;
        }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
