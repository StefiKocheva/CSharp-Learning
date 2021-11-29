namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;

    public static class Satrtup
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                var info = command.Split(" ");

                Trainer trainer = new Trainer();
                trainer.Name = info[0];
                Pokemon pokemon = new Pokemon(info[1], info[2], int.Parse(info[3]));
                trainer.Pokemons.Add(pokemon);
                trainers.Add(trainer);

                command = Console.ReadLine();
            }

            string givenElement = Console.ReadLine();

            foreach (var trainer in trainers)
            {
                int trueStatement = 0;

                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Element == givenElement)
                    {
                        trainer.NumberOfBadges += 1;
                        trueStatement++;
                    }
                }

                if (trueStatement == 0)
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }

                foreach (var pokemon in trainer.Pokemons)
                {
                    if (pokemon.Health <= 0)
                    {
                        trainer.Pokemons.Remove(pokemon);
                    }
                }
            }
                //while (givenElement != "End")
                //{
                //    
                //    }
                //
                //    givenElement = Console.ReadLine();
                //}
                //

                foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons}");
            }
        }
    }
}
