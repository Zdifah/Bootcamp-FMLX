using System.ComponentModel;
using System.Numerics;

class Program
{
	static void Main()
	{
		Phone phone = new(10);
		Hammer hammer = new(20);
		
		Box box = new();
		box.AddProduct(phone);
		box.AddProduct(hammer);
		
		System.Console.WriteLine(box.GetPrice());
	}
}

//Component
public interface IProduct
{
	public int GetPrice();
}

//Leaf
class Phone : IProduct
{
	private int _price;
	public Phone(int price)
	{
		_price = price;
	}
	
	public int GetPrice()
	{
		return _price;
	}
}

//Leaf
class Hammer : IProduct
{
	private int _price;
	public Hammer(int price)
	{
		_price = price;
	}
	
	public int GetPrice()
	{
		return _price;
	}
}

//Box
class Box : IProduct
{
	private List<IProduct> _warp = new List<IProduct>();
	
	public void AddProduct(IProduct obj)
	{
		_warp.Add(obj);
	}
	
	public void RemoveProduct(IProduct obj)
	{
		_warp.Remove(obj);
	}
	
	public int GetPrice()
	{
		int totalPrice = 0;
		foreach(var item in _warp)
		{
			totalPrice += item.GetPrice();
		}
		
		return totalPrice;
	}
}