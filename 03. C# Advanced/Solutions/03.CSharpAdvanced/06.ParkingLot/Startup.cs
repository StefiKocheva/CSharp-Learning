namespace _06.ParkingLot
{
    using System;
    using System.Collections.Generic;

    public static class Startup
    {
        public static void Main()
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string carInfo = Console.ReadLine();

            while (carInfo != "END")
            {
                string[] carData = carInfo.Split(", ");

                switch (carData[0])
                {
                    case "IN":
                        parkingLot.Add(carData[1]);
                        break;
                    case "OUT":
                        parkingLot.Remove(carData[1]);
                        break;
                }

                carInfo = Console.ReadLine();
            }

            Console.WriteLine(parkingLot.Count > 0 ? string.Join(Environment.NewLine, parkingLot) : "Parking Lot is Empty");
        }
    }
}
