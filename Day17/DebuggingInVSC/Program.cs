class Program
{
	static void Main()
	{
		var math = new Math();
		
		math.CircleArea(5.0f);
	}
}

class Math
{
	public const int gravitasi = 10;
	public const float pi = 3.14f;
	
	public float CircleArea(float radius)
	{
		float areaCircle = pi * radius * radius * gravitasi;
		return areaCircle;
	}
}