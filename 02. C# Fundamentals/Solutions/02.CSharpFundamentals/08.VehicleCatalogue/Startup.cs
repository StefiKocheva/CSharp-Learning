namespace _08.VehicleCatalogue
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            var catalog = new Catalog();

            string command = Console.ReadLine();

            while (command != "end")
            {
                var data = command.Split("/").ToArray();

                if (data[0] == "Car")
                {
                    var car = new Car()
                    {
                        Brand = data[1],
                        Model = data[2],
                        HorsePower = int.Parse(data[3]),
                    };

                    catalog.Cars.Add(car);
                }
                else
                {
                    var truck = new Truck()
                    {
                        Brand = data[1],
                        Model = data[2],
                        Weight = int.Parse(data[3]),
                    };

                    catalog.Trucks.Add(truck);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Cars:");

            catalog.Cars.OrderBy(car => car.Brand).ToArray();

            foreach (var car in catalog.Cars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            Console.WriteLine("Trucks:");

            catalog.Trucks.OrderBy(truck => truck.Brand).ToArray();

            foreach (var truck in catalog.Trucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
}
