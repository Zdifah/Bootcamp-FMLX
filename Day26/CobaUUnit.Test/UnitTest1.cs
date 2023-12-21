using pakk;
namespace CobaUUnit.Test;

[TestFixture]
public class Tests
{
	private NumberCalculation numberCalculation;
	[SetUp]
	public void Setup()
	{
		numberCalculation = new NumberCalculation();
	}

	[TestCase(1,1,2)]
	[TestCase(2,2,4)]
	[TestCase(3,3,6)]
	public void Add_CorrectNumber(int a, int b, int expected)
	{
		//arrange
		
		// act
		int actual = numberCalculation.Add(a,b);
		
		// Assert
		Assert.That(actual, Is.EqualTo(expected));
	}
}