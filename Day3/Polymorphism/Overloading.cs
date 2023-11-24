namespace Overloading;

public class Calculator
{
	/*
	* overloading adalah sebuah fitur yang memungkin kita untuk membangun
	* contruction sebuah class atau method dengan berbagai patameter yang berbeda namu
	* dengan nama contruction dan class yang sama
	*/
	// overloading bisa untuk constructor dan metho
	// contoh untuk constructor
	
	public int a;
	public int b;
	public int c;
	//overloading pada constructor
	public Calculator()
	{
		a = 0;
	}
	public Calculator(int a,int b)
	{
		this.a = a;
		this.b =b;
	}
	public Calculator(int a, int b, int c)
	{
		this.a = a;
		this.b = b;
		this.c = c;
	}
	
	//overloading untuk method
	
	public int Add(int a, int b)
	{
		return a + b;
	}
	
	public int Add(int a, int b, int c)
	{
		return a + b + c;
	}
	public float Add(float a, float b)
	{
		return a + b;
	}
	public float Add(float a, float b, float c)
	{
		return a + b + c;
	}
}
