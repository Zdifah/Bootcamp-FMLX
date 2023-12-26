using DatabaseFirst;
using Microsoft.EntityFrameworkCore;

class Program
{
	static async Task  Main()
	{
		using (City db = new City())
		{
			City_Table cityData = await db.cityDataBases.FirstOrDefaultAsync(p => p.Country == "indonesia");
			Console.WriteLine(cityData.City);
			
		}
	}
}