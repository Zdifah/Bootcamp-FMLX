using System;
class Program
{
	static void Main()
	{
		/*
		Action dan Func adalah sebuah delegate yang telah disediakna dari C#.
		Action<Tparameter> --> delegate void
		Func<Tparameter, Toutput> --> delegate return
		
		jika pengunaan delegate harus decalare delegate method, lalu melakukan
		inisialisasi method. pada pengunaan action dan func langsung melakukan
		inisialisasi method
		*/
		/*
		step using Action and func
		1.declare Action or Func if with variable, you want parameter give <Tparameter> for action, <Tparameter,Touput> for func
		2.done
		*/
		public event Action<> MyAction;
		MyAction myAction += Test;
		
		System.Console.WriteLine(myAction);
	}
	static void Test()
	{
		System.Console.WriteLine("testing aja ya");
	}
}