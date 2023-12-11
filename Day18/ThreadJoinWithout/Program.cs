using System;
using System.Threading;

public class Program
{
	/*
	alur program ini adalah ketika main thread berjalan akan menghasilkan
	"Starting program", lalu membuat instance thread yang berisi method
	DoTask, lalu instance thread akan menjalan method DoTask, karna DoTask
	sudah terpanggil dan tidak menggunakan thread.Join maka di main Thread
	akan lanjut menjalankan "Program complete". untuk hasil DoTask bisa jadi
	akan selesai sesudah "program complete" atau bahkan sebelumnya.
	kenapa bisa kaya gini karna instance thread itu membuat jalur tersendiri
	yang terpisah dari main threadnya.
	*/
	public static void Main()
	{
		Console.WriteLine("Starting program.");

		var task = new Thread(DoTask);

		task.Start();

		Console.WriteLine("Program complete.");
	}

	public static void DoTask()
	{
		Console.WriteLine("Starting task.");
		Thread.Sleep(2000);
		Console.WriteLine("Task complete.");
	}
}
