using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseSelfLib;

[Keyless]
public class Cities
{
	public string City {get; set;} = null!;
	public string Country {get; set;} = null!;
	public int Population {get; set;}	
}
