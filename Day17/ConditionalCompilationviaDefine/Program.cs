#define Testing
class Program
{
	/*
	conditional complilation itu bertujuan untuk menjalankan sebagian
	program yang kita tandain. cara menandakannya dengan memberikan
	#if NAMA lalu kita jalankan dengan perintah #define TARGETNAMA
	
	fitur ini bertujuan untuk menjalankan program dengan kondisi program
	development satu file dengan program production. lalu kita hanya
	ingin menjalankan program developmentnya aja. ini salah satu
	penggunaan untuk conditional compilation	
	
	sebenarnya jika kita tidak memberikan TARGETNAMA yang berjalan adalah
	DEBUG. jadi ketika kita memberika TARGETNAMA kita menjalankan 2 kondisi
	yaitu TARGETNAMA dan DEBUG. akan lebih jelas lagi ketika kita menjalankan
	lewat dotnet
	*/
	
	static void Main()
	{
		#region CobaAJA
		#if Testing
		System.Console.WriteLine("Testing yaa!!");
		#elif Bang
		System.Console.WriteLine("bang udah bang");
		#elif YaudahIya
		System.Console.WriteLine("YA UDAH IYAAA");
		#endif
		#endregion
	}
}