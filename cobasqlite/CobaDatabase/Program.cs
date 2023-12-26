using MyCobaDataBase;
using Microsoft.EntityFrameworkCore;

class Program
{
	static void Main()
	{
		// i want to access external file and i will using keyword for managed memory
		using (Northwind db = new Northwind())
		{
			if (db.Database.CanConnect())
			{
				System.Console.WriteLine("koneksi berhasil");
			}else
			{
				System.Console.WriteLine("koneksi gagal");
			}
			
			// read data
			List<Category> categories = db.Categories.Include(c => c.Products).ToList();
			foreach(var c in categories)
			{
				// Console.WriteLine(c);
				Console.WriteLine(c.CategoryName);
				Console.WriteLine(c.Products.Count);
				foreach(var p in c.Products) 
				{
					Console.WriteLine("\t" + p.ProductName);
				}
			}
			
			// // read data
			// IQueryable<Product> products = db.Products.Where(p => p.UnitPrice > 50);
			// foreach(var item in products)
			// {
			// 	Console.WriteLine($"{item.ProductName} ==> {item.UnitPrice}");
			// }
			
			// // cud (create update delete) ==> must be save change
			// // create
			// Category category = new Category()
			// {
			// 	CategoryName = "Toy",
			// };
			// await db.Categories.AddAsync(category);
			// await db.SaveChangesAsync();
			
			// update
			// Category update = await db.Categories.FindAsync(9);
			// update.CategoryName = "Mainan Anak-anak";
			// await db.SaveChangesAsync();
			
			// delete
			// Category del = await db.Categories.FindAsync(9);
			// db.Categories.Remove(del);
			// await db.SaveChangesAsync();
			
			// search Pk by category name
			// Category searchCategory = await db.Categories.FirstOrDefaultAsync(p => p.CategoryName == "Beverages");
			// Console.WriteLine(searchCategory.CategoryName);
		}
	}
}