using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst;
public class City : DbContext
{
	public DbSet<City_Table> cityDataBases {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = city.db");
    }
}
