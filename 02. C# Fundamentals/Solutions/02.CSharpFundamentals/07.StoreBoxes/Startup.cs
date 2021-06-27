namespace _07.StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            var boxes = new List<Box>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                var boxData = command.Split().ToArray();

                var box = new Box()
                {
                    SerialNumber = boxData[0],
                    ItemQuantity = int.Parse(boxData[2]),
                    Item = new Item()
                    {
                        Name = boxData[1],
                        Price = decimal.Parse(boxData[3]),
                    }
                };

                box.Price = box.Item.Price * box.ItemQuantity;

                boxes.Add(box);

                command = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} – ${Math.Round(box.Item.Price, 2)}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${Math.Round(box.Price, 2)}");
            }
        }
    }
}
