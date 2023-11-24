class Program
{
	static void Main()
	{
		/*
		string itu reference type tapi dia immutable ga nilainya ga bisa diubah
		jadi kalo mau maksa ubah dia sebenarnya bikin addres baru dengna nilai
		yang beda
		
		NOTE: penggunaan string sangat tidak direkomendasikan untuk
		melakukan write berulang terus menerus. karna setiap dia ganti nilai
		artinya dia ganti memorynya juga itu menyakitkan untuk CPU
		*/
		
		string a = "Ilham";
		string b = a;
		
		b = "fahry"; // sebenarnya b = a dan b = "fahry" berada di memory yang berbeda
		
		System.Console.WriteLine(a);
		System.Console.WriteLine(b);
	}
}