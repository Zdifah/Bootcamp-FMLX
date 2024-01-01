using System;
using Microsoft.EntityFrameworkCore;

namespace LearnCodeFirst;

public class MyDataBase :DbContext
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(@"FileName = ./MyDataBase.db");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// fluen API
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired().HasMaxLength(20);
			category.Property(c => c.Description).IsRequired(false).HasMaxLength(40);
			// untuk mengatur hubungan category dengan produc
			//.HasMany() ==> artinya category mempunyai hubungan banyak dengan product
			category.HasMany(c => c.Products).WithOne(p => p.Category);
		});
		
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			// karna di modelBuilder.Entity<Category> sudah ada yang mengatur hubungan category dengan
			// product jadi di sini ga udah mengaturnya
			// product.HasOne(p => p.Category);
			product.Property(p => p.ProductName).IsRequired().HasMaxLength(20);
			product.Property(p => p.Cost).IsRequired().HasColumnName("ProductCost").HasColumnType("money");
		});
		
		//seeding
		//seeding itu kita membuat data default jadi sebelum database dibuat kita udah punya data
		//yang mau dimasukin 
		modelBuilder.Entity<Category>().HasData(
			new Category()
			{
				CategoryId = 1,
				CategoryName = "Action Figure",
				Description = "Berhala ANIMEK"
			},
			new Category()
			{
				CategoryId = 2,
				CategoryName = "Game",
				Description = "beli game ori bang jangan bajakan terus"
			}
		);
		
		modelBuilder.Entity<Product>().HasData(
			new Product()
			{
				ProductId = 1,
				ProductName = "Hatsune Miku ver senbonzakura",
				CategoryId = 1,
				QuantityPerUnit = 1,
				Cost = 1000000,
			}
		);
	}


	
}
