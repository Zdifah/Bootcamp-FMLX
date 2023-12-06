using System;

namespace LOHDemo
{
	/* 
	jika ada object yang besar lebih dari 80kb maka dia akan ditempatkan
	di LOH (large Object Heap) dia akan di hapus jika gen 2 di bersihkan
	*/
	class Program
	{
		static void Main(string[] args)
		{
			float[] largeArray = new float[100 * 1024];  // 400 KB

			Console.WriteLine("Large object allocated on the LOH.");
			Console.ReadKey();
		}
	}
}
