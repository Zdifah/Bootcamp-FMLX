using System.Runtime.Intrinsics.Arm.Arm64;
using System.Linq;
class Program
{
	static void Main()
	{
		Child child = new Child();
		Console.WriteLine(child.b); // 2
	}
}

class Parent 
{
	public int a = 2;
}
class Child : Parent
{
	public int b;
	
	public Child (int base.a)
	{
		b = base.a;
	}
}