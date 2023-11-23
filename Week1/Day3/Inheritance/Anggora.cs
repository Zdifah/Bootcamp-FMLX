namespace AnimalKingdom;

public class Anggora : Cat
{
	public string food;
	public Anggora(string name,bool isLongTail, string food) : base(name,isLongTail)
	{
		this.name = name;
		this.isLongTail = isLongTail;
		this.food = food;
	}
	
	public void CatElit()
	{
		Console.WriteLine("aku ini kucing mahal bang");
	}
}
