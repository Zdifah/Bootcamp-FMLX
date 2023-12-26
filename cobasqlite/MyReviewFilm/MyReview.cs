using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyReviewFilm;

public class MyReview
{
	[Key]
	public int Id {get; set;}
	public string REVIEW {get; set;} = null!;
	public int RATING {get; set;}
	[StringLength(255)]
	public string AUTHOR {get; set;} = null!;
	public string TITLE {get; set;} = null!;
	
}
