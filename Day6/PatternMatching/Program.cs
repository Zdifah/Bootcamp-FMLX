class Program
{
	static void Main()
	{
		object obja = 3;
		object objb = 2;
		Add(obja, objb);
	}
	static void Add(object a, object b)
	{
		/*
		a is int inta ---> pattern matching 
		jika a int maka inta akan bernilai a
		*/
		if (a is int inta && b is int intb)
		{
			System.Console.WriteLine(inta + intb);
		}
		if (a is float floata && b is float floatb)
		{
			System.Console.WriteLine(floata + floatb);
		}
		if (a is string stringa && b is string stringb)
		{
			System.Console.WriteLine(stringa + stringb);
		}
	}
}