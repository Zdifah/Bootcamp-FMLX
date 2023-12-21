namespace QuickMath;
class Program
{
	/*
	Nunit adalah alat untuk kita menguji program yang kita buat. hal yang diuji adalah sebuah method
	yang bersifat public. jika kita ingin menggunakan Nunit ada beberapa tahap yaitu
	
	1. buat project yang ingin diuji dimana project tersebut sudah selesai ex: Math
	2. buat project baru tipe Nunit dengan nama seperti yang ingin diuji lalu tambahkan .Test ex : Math.Test
		ini hanya masalah penamaan karna mempermudah unit test ini mau nguji yang mana
	3. install package Nunit di pengujinnya
	4. buat attribute [TestFixture] sebelum class pengujianya
	5. di dalam class pengujinya buat komposisi class diuji
	6. buat instans diuji di dalam Setup()
	7. buat method penguji return void dengan penamaan
	*/
	static void Main()
	{
		NumberCalculation numberCalc = new();
		int a = 10;
		int b = 12;

		Console.WriteLine($"Addition of {a} and {b} is {numberCalc.Add(a, b)}");
		Console.WriteLine($"Subtraction of {a} and {b} is {numberCalc.Subtract(a, b)}");
		Console.WriteLine($"Multiplication of {a} and {b} is {numberCalc.Multiply(a, b)}");
		Console.WriteLine($"Division of {a} and {b} is {numberCalc.Divide(a, b)}");
	}
}

public class NumberCalculation
	{
		public int Add(int a, int b) 
		{
			return a + b;
		}
		public int Multiply(int a, int b) 
		{
			return a * b;
		}
		public int Subtract(int a, int b) 
		{
			return a - b;
		}
		public int Divide(int a, int b) 
		{
			return a / b;
		}
	}