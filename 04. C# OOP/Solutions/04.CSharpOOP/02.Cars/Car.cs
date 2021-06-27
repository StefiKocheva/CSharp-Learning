namespace _02.Cars
{
    public abstract class Car : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public virtual string Start() => "Engine start";

        public virtual string Stop() => "Breaaak!";
    }
}
