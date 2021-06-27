namespace _02.Animals
{
    public class Animal
    {
        private string name;
        private string favoriteFood;

        public Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf() 
            => $"I am {this.name} and my favorite food is {this.favoriteFood}";
    }
}
