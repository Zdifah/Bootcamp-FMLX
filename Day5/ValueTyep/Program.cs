class Program
{
	static void Main()
	{
		/*
		value type adalah nilai yang berada di LoFI, ingat dan lupakan
		dia berada distack. yang berada distack tidak bisa di inheritance.
		dan ketika kita menggunakan variable value type lalu mencopy kita
		sebenarnya hanya mencopy valuenya saja tanpa addresnya.
		*/
		/*
		value type merupakn tipe data primitive yaitu
		int, byte, long, double, float, char, bool
		*/
		int a = 10;
		int b = a;
		
		b = 99;
		
		System.Console.WriteLine(a);
		System.Console.WriteLine(b);
		
		float pi = 3.14f;
		float g = pi;
		g = 9.98f;
		
		System.Console.WriteLine(pi);
		System.Console.WriteLine(g);
		
		char test = 'a';
		char test2 = test;
		test2 = 'x';
		
		System.Console.WriteLine(test);
		System.Console.WriteLine(test2);
	}
}