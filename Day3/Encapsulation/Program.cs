class Program
{   
	static void Main()
	{
		Waiters waiters = new Waiters("Nasi Goreng");
		Chef chef = new Chef(waiters.KasihPesananKeChef());
		chef.MenerimaPesanan();
	}
}

class Chef
{
	private string _pesananDiterima;
	public Chef(string pesanan)
	{
		this._pesananDiterima = pesanan;
	}
	private void Masak()
	{
		if (!String.IsNullOrWhiteSpace(_pesananDiterima))
		{
			Console.WriteLine("SIAP MEMASAK");
		}else
		{
			Console.WriteLine("MALAS");
		}
	}
	public void MenerimaPesanan()
	{
		Masak();
	}
}
class Waiters
{
	private string _pesanan;

	public Waiters(string pesanan)
	{
		this._pesanan = pesanan;
	}
	
	public string KasihPesananKeChef()
	{
		return _pesanan;
	}
}