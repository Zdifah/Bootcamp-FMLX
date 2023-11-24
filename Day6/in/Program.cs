//Value Type
//In = ReadOnly
//Variable must be assigned before passed
//But its ReadOnly

class Program
{
	static void Main()
	{
		/*
		karna ini primitive type dia berada di stack jika nilainya berubah makan addresnya juga akan berubah
		oleh karna itu jika dipasang in akan hanya readonly saja
		*/
		int a = 3;
		AddTwo(a);
		Console.WriteLine(a); // ? 3 , 5
	}
	static void AddTwo(in int x)
	{
		// x = x + 3; //<- Error, change value not possible
		System.Console.WriteLine(x);
	}
}