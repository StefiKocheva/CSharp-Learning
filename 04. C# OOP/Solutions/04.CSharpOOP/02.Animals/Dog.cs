namespace _02.Animals
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood)
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
            => base.ExplainSelf() + Environment.NewLine + "DJAAF";
    }
}
