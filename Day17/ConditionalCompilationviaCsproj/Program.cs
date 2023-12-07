class Program
{
	/*
	kita ingin menjalankan conditional compilation dengan memberikan
	target condition lewat csproj. dengan memberikan <DefineConstants>TARGETNAMA</DefineConstants>
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