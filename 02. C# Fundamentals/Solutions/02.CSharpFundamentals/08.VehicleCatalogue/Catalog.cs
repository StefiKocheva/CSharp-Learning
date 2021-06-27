namespace _08.VehicleCatalogue
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
}
