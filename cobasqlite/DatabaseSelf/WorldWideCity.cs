using Microsoft.EntityFrameworkCore;

namespace DatabaseSelfLib;
public class WorldWideCity : DbContext
{
	public DbSet<Cities> Cities {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"FileName = ./city.db");
    }
	
}
