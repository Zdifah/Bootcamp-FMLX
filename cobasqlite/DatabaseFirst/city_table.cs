using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseFirst;
public class City_Table
{
	public string City {get; set;} = null!;
	public string Country {get; set;} = null!;
	public int Population {get; set;}
}
