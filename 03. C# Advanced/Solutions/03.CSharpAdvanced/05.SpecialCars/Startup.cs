namespace _05.SpecialCars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            List<Tire[]> tires = new List<Tire[]>();

            List<Engine> engines = new List<Engine>();

            List<Car> cars = new List<Car>();

            while (command != "No more tires")
            {
                string[] tireData = command.Split();

                Tire[] currentTires = new Tire[4]
                {
                     new Tire(int.Parse(tireData[0]), double.Parse(tireData[1])),
                     new Tire(int.Parse(tireData[2]), double.Parse(tireData[3])),
                     new Tire(int.Parse(tireData[4]), double.Parse(tireData[5])),
                     new Tire(int.Parse(tireData[6]), double.Parse(tireData[7]))
                };

                tires.Add(currentTires);

                command = Console.ReadLine();
            }

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Engines done")
                {
                    break;
                }

                string[] engineData = command.Split();

                Engine engine = new Engine(int.Parse(engineData[0]), double.Parse(engineData[1]));

                engines.Add(engine);
            }

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Show special")
                {
                    break;
                }

                string[] carInfo = command.Split();

                Car car = new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2]), double.Parse(carInfo[3]), double.Parse(carInfo[4]), engines[int.Parse(carInfo[5])], tires[int.Parse(carInfo[6])]);

                cars.Add(car);
            }

            foreach (var specialCar in cars.Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 && car.Tires.Select(c => c.Pressure).Sum() > 9 && car.Tires.Select(c => c.Pressure).Sum() < 10))
            {
                specialCar.Drive(20);

                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}