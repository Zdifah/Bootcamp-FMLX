class Program
{
	static void Main()
	{
		/*
		refrence type kebalikan value type nilai dia disimpan di dalam heap
		jika kita mencopy variable reference type lalu kita mengubahnya maka
		variabel awalnya juga berubah
		*/
		/*
		reference type itu non primitive type kaya strin, array, class
		yang ada new nya itu reference type
		*/
		Car a = new Car(10);
		
		Car b = a;
		b.value = 50;
		
		System.Console.WriteLine(a.value);
		System.Console.WriteLine(b.value);
	}
}

class Car
{
	public int value;
	public Car(int input)
	{
		value = input;
	}
}