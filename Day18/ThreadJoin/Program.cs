using System;
using System.Threading;

public class Program
{
	public static void Main()
	{
		/*
		alur program ini  adalah ada 2 thread yaitu main thread
		main thread akan menjalankan "strating program", lalu membuat
		instance thread berisi method DoTask, lalu instance thread akan
		menjalan method DoTask, lalu main thread akan menunggu instance 
		thread karna terdapat syntax thread.Join() menunggu hingga method
		DoTask selesai, lalu ketika menjalankan DoTask akan menghasilkan
		"starting task" lalu blocking instance thread selama 2 detik lalu
		menghasilkan "Task complete", lalu main thread akan menghasilkan
		"Program complete"
		*/
		Console.WriteLine("Starting program.");

		Thread thread = new Thread(DoTask);

		thread.Start();
		thread.Join();

		Console.WriteLine("Program complete.");
	}

	public static void DoTask()
	{
		Console.WriteLine("Starting task.");
		Thread.Sleep(2000);
		Console.WriteLine("Task complete.");
	}
}
