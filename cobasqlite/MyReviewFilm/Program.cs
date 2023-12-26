using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using MyReviewFilm;

class Program
{
	static void Main()
	{
		using (MyFilm db = new MyFilm())
		{
			if (db.Database.CanConnect())
			{
				System.Console.WriteLine("Koneksi Berhasil");
			}else
			{
				System.Console.WriteLine("Koneksi Gagal");
			}
			
			IQueryable<MyReview> myReview = db.Reviews.Where(p => p.RATING > 8);
			foreach(var item in myReview)
			{
				System.Console.WriteLine(item.TITLE);
			}
		}
	}
}