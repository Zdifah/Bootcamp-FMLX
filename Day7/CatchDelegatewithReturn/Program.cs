//Delegate Return Value
public delegate int MyDelegate(int a, int b);
public class Program
{
	/*
	jika kita memasukan beberapa subscribers ke dalam publisher dimana delegate
	memiliki return maka hasil yang keluar merupkan subscriber terakhir didaftarkan.
	jika kita ingin menyimpan semua nilai dari subcribers kita harus menangkapnya
	*/
	static void Main()
	{
		Calculator calc = new();
		MyDelegate del = calc.Add;
		del += calc.Sub;

		Delegate[] delegateList = del.GetInvocationList();
		int[] result = new int[delegateList.Length];
		int count = 0;
		foreach(MyDelegate d in delegateList) {
			result[count] = d.Invoke(10,9);
			count++;
		}
		foreach(int i in result) {
			System.Console.WriteLine(i);
		}
	}
}
public class Calculator
{
	public int Add(int a, int b)
	{
		return a + b;
	}
	public int Sub(int a, int b)
	{
		return a - b;
	}
}