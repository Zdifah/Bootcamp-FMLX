using Microsoft.EntityFrameworkCore;

namespace MyCobaDataBase;

public class Northwind : DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
		optionsBuilder.UseSqlite(@"FileName = ./Northwind.db");
    }
}