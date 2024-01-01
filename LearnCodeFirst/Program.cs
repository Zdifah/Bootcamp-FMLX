using LearnCodeFirst;
using Microsoft.EntityFrameworkCore;

class Program
{
	static void Main()
	{
		using (MyDataBase db = new MyDataBase())
		{
			// Category category = new Category()
			// {
			// 	CategoryId = 5,
			// 	CategoryName = "Peralatan Gunug",
			// 	Description = "Healing bang keluar"
			// };
			// await db.Categories.AddAsync(category);
			// await db.SaveChangesAsync();
			
			Category findCategory = db.Categories.FirstOrDefault(c => c.CategoryName == "Peralatan Gunug");
			if (findCategory != null)
			{
				System.Console.WriteLine("ini ada ");
			}else
			{
				System.Console.WriteLine("ga ada tuh");
			}
		}
	}
}