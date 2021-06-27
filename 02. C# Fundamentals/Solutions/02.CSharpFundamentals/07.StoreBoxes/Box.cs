namespace _07.StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal Price { get; set; }
    }
}
