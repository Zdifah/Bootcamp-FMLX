using QuickMath;

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
	[TestCase(4,4,8)]
	public void Add_CorrectNumber(int a, int b, int expected)
	{
		// Arrenge
		
		// Act
		int actual = numberCalculation.Add(a,b);
		
		// Assert
		Assert.That(actual, Is.EqualTo(expected));
	}
}