using VirtualAndOverride;

namespace MethodHiding;

public class Animal
{
	public void MakeSound(string test)
	{
		Console.WriteLine("Make Sound");
	}
}

public class Cat : Animal
{
	public new void MakeSound()
	{
		Console.WriteLine("MEOW");
	}
}
