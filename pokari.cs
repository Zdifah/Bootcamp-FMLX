// blueprint kucing
class Cat
{
	public string? colour;
	public int age;
	public bool isMale;
	public float weight;
	
	public Cat(string colour)
	{
		this.colour = colour;
		age = 3;
		isMale = true;
		weight = 10;
	}
	
	public void Eat()
	{
		System.Console.WriteLine("Eat");
	}
	
	public void Sleep()
	{
		System.Console.WriteLine("Sleep");
	}
	public void Meow()
	{
		System.Console.WriteLine("Meow");
	}
}