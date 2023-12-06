// string builder
using System;
using System.Diagnostics;
using System.Text;

class Program {
	static void Main() {
		
		StringBuilder sb = new StringBuilder();
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		for (long i = 0; i < 100000000000000000; i++) {
			sb.Append("a");
			sb.Append("b");
			sb.Replace('a', 'c');
		}
		stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
	}
}
