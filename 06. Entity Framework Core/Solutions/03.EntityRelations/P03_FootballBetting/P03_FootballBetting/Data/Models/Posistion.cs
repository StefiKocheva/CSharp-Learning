namespace P03_FootballBetting.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Posistion
    {
        public Posistion()
        {
            this.Players = new HashSet<Player>();  
        }

        public int PosistionId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
