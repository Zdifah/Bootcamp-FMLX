class Program
{
	static void Main()
	{
		MyInt myInt = new();
		myInt.value = 3;
		AddTwo(myInt); // 5
		System.Console.WriteLine(myInt.value);
	}
	static void AddTwo(MyInt a)
	{
		a.value = a.value + 2;
	}
}

class MyInt
{
	public int value;
}