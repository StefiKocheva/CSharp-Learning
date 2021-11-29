namespace ExplicitInterfaces
{

    public class Citizen : IPerson, IResident
    {
        public string Name { get ; set; }

        public string Country { get; set; }

        public string Age { get ; set; }

        public string GetName()
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
