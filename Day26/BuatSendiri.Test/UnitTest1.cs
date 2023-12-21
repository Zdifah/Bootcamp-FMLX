using BuatSendiriLib;
namespace BuatSendiri.Test;

[TestFixture]
public class Tests
{
	NumberCalculation numberCalculation;
	
	// attribut setup berfungsi untuk setiap instance di dalamnnya dipanggil maka akan dibuatkan instance baru jika ingi
	// setiap dipanggil menggunkan instance yang sama maka attribut yang digunakan [OnTImeSetup]
	[SetUp] 
	public void Setup()
	{
		numberCalculation = new();
	}

	// attribute [TestCase] dapat memberika multiple input untuk pengujian
	[TestCase(1,1,2)]
	[TestCase(2,2,4)]
	[TestCase(4,4,8)]
	public void Add_ANGKABENER(int a, int b, int expected)
	{
		// arrange (bagia untuk deklar nilai varible) karna kita menggunakan attributes [TestCase] maka arrange bakal kosong
		
		// act (bagian untuk mengmanggil method yang ingin diuji)
		int actual = numberCalculation.Add(a,b);
		
		// Assert (bagian untuk menilai apakah output dari method yang diuji sesaui dengan expected atau tidak)
		Assert.That(expected, Is.EqualTo(actual));
	}
	
	// attribute ini untuk memberi tahu kalo method ini bakal nguji
	[Test]
	public void Multiply_ShouldCorrectNumber()
	{
		int a = 10;
		int b = 20;
		int expected = 200;
		
		int actual = numberCalculation.Multiply(a,b);
		
		Assert.That(expected, Is.EqualTo(actual));
	}
	
	[Test]
	public void Subtract_ShouldCorrectNumber()
	{
		int a = 2;
		int b = 1;
		int expected = 1;
		
		int actual = numberCalculation.Subtract(a,b);
		
		// Assert.AreEqual versi lama tapi sebenarnya tetap bisa jalan
		Assert.AreEqual(expected, actual);
	}
	
	
}