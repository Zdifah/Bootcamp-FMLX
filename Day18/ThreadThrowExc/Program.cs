using System;
using System.Threading;

class Program
{
	/*
	jika di thread lain terdapat error maka main thread tidak bisa
	men-throw error tersebut karna error yang terjadi berada di thread yang
	berbeda
	*/
	static void Main()
	{
		Thread thread = new Thread(() => { throw new InvalidOperationException("An error occurred!"); });

		try
		{
			thread.Start();
			thread.Join();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception caught: " + ex.Message);
		}
	}
}
