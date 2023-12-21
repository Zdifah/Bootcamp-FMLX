namespace TryUnit.Test;
using BuatSendiriLibXUnit;

// cara penggunaan Xunit hampir mirip dengan Nunit yang membedakan hanya attribute yang digunakan dan syntax
public class UnitTest1
{
	NumberCalculation numberCalculation1 = new();
	[Fact]
	public void Test1()
	{
		NumberCalculation numberCalculation = new();
		int a = 1;
		int b = 2;
		int expected = 3;
		
		int actual = numberCalculation.Add(a,b);
		
		Assert.Equal(expected, actual);
	}
	
	[Fact]
	public void Test2()
	{
		int a = 1;
		int b = 1;
		int expected = 2;
		
		int actual = numberCalculation1.Add(a,b);
		
		Assert.Equal(expected, actual);
	}
	
	[Theory]
	[InlineData(1,1,1)]
	[InlineData(2,2,4)]
	[InlineData(3,3,9)]
	public void Test3(int a, int b, int expected)
	{
		NumberCalculation numberCalculation = new();
		
		int actual = numberCalculation.Multiply(a,b);
		
		Assert.Equal(expected, actual);
	}
}