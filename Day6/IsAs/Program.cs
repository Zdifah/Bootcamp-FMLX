class Program
{
	// is --> untuk checking
	// as --> untuk eksplisit cast
	static void Main()
	{
		// pengunaan as
		object a = "ilham";
		var hasila = a as string;// --> seperti cast eksplisit
		// sama saja sepeti var hasila = (string) a;
		
		// pengunaan is
		object b = true;
		if (b is bool)
		{
			bool hasilb = (bool) b;
		}
		
		Type type = b.GetType();
		Type type2 = typeof(Boolean);
		if(type == type2)
		{
			bool hasilb = (bool) b;
			System.Console.WriteLine(hasilb);
		}
	}
}