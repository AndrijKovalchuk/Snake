namespace Db
{
    using Microsoft.EntityFrameworkCore;
    public class SqLiteContext : DbContext
    {
        public DbSet<Score> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Snake.db");
        }
    }
}
