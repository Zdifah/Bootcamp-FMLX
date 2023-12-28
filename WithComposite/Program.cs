class Phone
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

class Hammer
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

class Box
{
	private List<object> _warp = new List<object>();
	
	public void AddProduct(object obj)
	{
		_warp.Add(obj);
	}
	
	public void RemoveProduct(object obj)
	{
		_warp.Remove(obj);
	}
	
	public int GetPrice()
	{
		int totalPrice = 0;
		foreach (var item in _warp)
		{
			// tidak bisa dilanjutkan karna kita harus melakukan unboxing
			totalPrice += _warp.GetPrice;
		}
		return totalPrice;
	}
}