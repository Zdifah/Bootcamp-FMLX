using System;
using System.Threading.Tasks;

class Program
{
	/*
	task adalah cara yang lebih modern dari thread
	*/
	static void Main()
	{
		Task task = new Task(() => Console.WriteLine("Hello, Task!"));
		TaskStatus x = task.Status;
		task.Start(); //Thread.Start();

		task.Wait(); //Thread.Join();
	}
}