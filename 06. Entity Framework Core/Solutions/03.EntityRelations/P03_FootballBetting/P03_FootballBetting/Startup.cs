namespace P03_FootballBetting
{
    using Microsoft.EntityFrameworkCore;
    using Data;

    public static class Startup
    {
        public static void Main()
        {
            using var db = new FootballBettingContext();

            db.Database.Migrate();
        }
    }
}
