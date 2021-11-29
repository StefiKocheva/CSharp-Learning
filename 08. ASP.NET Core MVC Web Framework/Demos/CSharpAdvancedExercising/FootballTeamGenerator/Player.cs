namespace FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name == null || this.name == string.Empty || char.IsWhiteSpace(this.name[0]) )
                {
                    Console.WriteLine("A name should not be empty.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            set
            {
                if (this.endurance >= 0 && this.endurance <= 100)
                {
                    this.endurance = value;
                }
                else
                {
                    Console.WriteLine($"{this.endurance} should be between 0 and 100.");
                }
            }
        }

        public int Sprint
        {
            get { return this.sprint; }
            set
            {
                if (this.sprint >= 0 && this.sprint <= 100)
                {
                    this.sprint = value;
                }
                else
                {
                    Console.WriteLine($"{this.sprint} should be between 0 and 100.");
                }
            }
        }

        public int Dribble
        {
            get { return this.dribble; }
            set
            {
                if (this.dribble >= 0 && this.dribble <= 100)
                {
                    this.dribble = value;
                }
                else
                {
                    Console.WriteLine($"{this.dribble} should be between 0 and 100.");
                }
            }
        }

        public int Passing
        {
            get { return this.passing; }
            set
            {
                if (this.passing >= 0 && this.passing <= 100)
                {
                    this.passing = value;
                }
                else
                {
                    Console.WriteLine($"{this.passing} should be between 0 and 100.");
                }
            }
        }

        public int Shooting
        {
            get { return this.shooting; }
            set
            {
                if (this.shooting >= 0 && this.shooting <= 100)
                {
                    this.shooting = value;
                }
                else
                {
                    Console.WriteLine($"{this.shooting} should be between 0 and 100.");
                }
            }
        }
    }
}