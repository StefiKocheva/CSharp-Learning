namespace P01_StudentSystem
{
    using P01_StudentSystem.Data;
    using Microsoft.EntityFrameworkCore;

    public static class StartUp
    {
        public static void Main()
        {
            using var db = new StudentSystemContext();

            db.Database.Migrate();
        }
    }
}
