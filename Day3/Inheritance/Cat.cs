namespace AnimalKingdom;
public class Cat :Animal
{
	public bool isLongTail;
	
	public Cat(string name, bool isLongTail) //:base("no name", 0)
	{
		this.name = name;
		this.isLongTail = isLongTail;
	}
		
	public void Meow()
	{
		Console.WriteLine("MEOWW");
	}
}
