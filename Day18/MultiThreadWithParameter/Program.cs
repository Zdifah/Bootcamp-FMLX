using System;
using System.Threading;

static class Program
{
	// jika kita ingin multi thread dengan method berparameter. 
	// parameternya harus berupa object. jika kita tidak ingin
	// parameternya object kita bisa melakukan dengan lamda expression
	static void Main()
	{
		int result; //nampung
		int x = 3; //kirim
		int y = 4; //kirim
		Thread myThread = new Thread(() =>
		{
			result = Add(x, y);
		});
		myThread.Start();
	}

	static void PrintNumbers(int value)
	{
		for (int i = 1; i <= 5; i++)
		{
			Console.WriteLine($"Thread: {i}");
			Thread.Sleep(1000);
		}
	}
	static int Add(int value, int value2 ) {
		return value + value2;
	}
}