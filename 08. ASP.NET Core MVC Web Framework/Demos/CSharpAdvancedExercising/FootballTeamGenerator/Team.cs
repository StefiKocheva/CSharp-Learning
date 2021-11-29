namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;

    public class Team 
    {
        private List<Player> players = new List<Player>();

        public Team(string name)
        {
            this.Name = name;
        }

        public Team()
        {
            this.NumberOfPlayers = this.players.Count;
        }

        public string Name { get; set; }

        public string Rating { get; private set; }

        public int NumberOfPlayers { get; private set; }     

        public void Add(string name, Player player)
        {
            this.players.Add(player);
        }

        public void Remove(Player player)
        {
            if (this.players.Contains(player))
            {
                this.players.Remove(player);
            }
            else
            {
                Console.WriteLine($"Player {player} is not in {this.Name} team.");
            }
        }
    }
}
