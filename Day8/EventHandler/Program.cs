using System.Diagnostics.Tracing;
using System;
class Program
{
	static void Main()
	{
		/*
			1. declare eventhandler
			2. create variable based on eventhandler
			3. create method that have same signature
			4. create trigger eventhandler
			5. make contract publisher and subscriber
		*/
		/*
		eventhandler seperti komunikasi antar objek karna dapat mengirim data.
		basic syntax --> "public EventHandler (variable name)" sama saja seperti "public delegate void VariableName (object sender, EventArgs args)"
		eventhandler generic --> "public EventHandler<T> (variable name)" sama saja seperti "public delegate void VariableName (obejct sender, T args)"
		biasanya eventhandler generic Tnya untuk menganti menjadi class
		dan class yang dijadikan tipe datanya diberika tanda " class A : EventArgs" 
		untuk memudahkan develpor lain ketika membacanya
		*/
		Pengirim pengirim = new Pengirim("Ilham");
		Penerima penerima = new Penerima();
		
		pengirim.subs += penerima.GetNotif;
		pengirim.SendNotif();
	}
}


class Pengirim
{
	public readonly string name;
	public event EventHandler subs;
	public Pengirim(string name)
	{
		this.name = name;
	}
	
	public void SendNotif()
	{
		subs?.Invoke(name, EventArgs.Empty);
	}
}

class Penerima
{
	public void GetNotif(object sender, EventArgs e)
	{
		System.Console.WriteLine($"dapet dari {sender}");
	}
}