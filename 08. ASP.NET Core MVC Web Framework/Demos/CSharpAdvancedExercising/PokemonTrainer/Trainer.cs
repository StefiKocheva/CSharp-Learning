namespace PokemonTrainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        public Trainer()
        {
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; } = 0;

        public List<Pokemon> Pokemons { get; set; }
    }
}
