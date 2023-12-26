using Microsoft.EntityFrameworkCore;

namespace MyReviewFilm;
public class MyFilm :DbContext
{
	public DbSet<MyReview> Reviews {get; set;}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite(@"FileName = ./IMDB_Movies_2021.db");
	}
	
}