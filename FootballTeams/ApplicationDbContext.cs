using Microsoft.EntityFrameworkCore;
namespace FootballTeams;

public class TeamDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Database=Teams;Integrated Security=false;User ID=root;Password=Alex228420;");
    }
}