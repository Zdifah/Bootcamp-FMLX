using System.Net.Http.Headers;

namespace LearnCodeFirst;

public class Category
{
	public int CategoryId { get; set; }
	public string  CategoryName { get; set; } = null!;
	public string  Description { get; set; } = null!;
	public ICollection<Product> Products { get; set; } = null!;
}
