namespace Type
{
    using System;
    public class Cat
    {
        private string name;
        private int age;
        private string color;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.color = "black";
        }

        public Cat(string name, int age, string color)
            : this(name, age)
        {
            this.color = color;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }

        public void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
}
