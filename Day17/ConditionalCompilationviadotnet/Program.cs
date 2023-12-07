class Program
{
	/*
	kita ingin menjalankan conditional compilation dengan memberikan
	target condition lewat terminal dotnet. dengan perintah dotnet run -c TARGETNAMA. 
	nanti akan keluar folder sesuai dengan TARGETNAMA di bin folder pada project
	
	seperti yang udah dijelasin di ConditionalCompilationviaDefine. ketika kita menjalankan
	conditional compilation dengan memberika TARGETNAMA sebenarnya kita menjalankan 2 kondisi
	yaitu TARGETNAMA dan DEBUG. lalu outputnya ada pada folder bin di project
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