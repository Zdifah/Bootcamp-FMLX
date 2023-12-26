using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using DatabaseSelfLib;

class Program
{
	static void Main()
	{
		
		using (WorldWideCity db = new WorldWideCity())
		{
			if (db.Database.CanConnect())
			{
				Console.WriteLine("koneksi berhasil");
			}else
			{
				Console.WriteLine("koneksi gagal");
			}
			Cities cities = db.Cities.FirstOrDefault(p => p.Country == "indonesia");
			
			System.Console.WriteLine(cities.City);		
			IQueryable<Cities> myCity = db.Cities.Where(p => p.Population > 1500);
			
			foreach(var item in myCity)
			{
				Console.WriteLine(item.City);
			}
		}
	}
}