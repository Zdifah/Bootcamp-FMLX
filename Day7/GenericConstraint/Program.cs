using System.Threading;
//Generic Constraint
using System.Numerics;
class Program
{
	static void Main()
	{
		/*
		generic constrain memberikan kita kemudahan dalam fleksibilitas
		dari batasan generic class. seperti jika generic class dan field
		atau methodnya bertipe generic maka dia tidak bisa dilakukan
		operasi logika, untuk mengatasi permaslahan itu generic constraint
		menambah kapabilitas sehingga dapat melakukan operasi logika tersebut.
		terdapat banyak jenis generic constraint. harus liat documentationnya
		kalo mau tau pilihan generic constrainya apa saja.
		*/
		System.Console.WriteLine(Calculator<int>.Add(10, 5));
		
		// karna generic dapat menjadi tipe atau class apapun
		// maka kita juga bisa melakukan operasi tambah pada class Car
		Car a = new Car(5);
		Car b = new Car(5);
		System.Console.WriteLine(Calculator<Car>.Add(a, b).price);
	}
}
// generic constraint dideklarasi dengan adanya "where T: bla bla"
//IAdditionalOperators<T,T,T> -> class generic dapat melakukan operasi +
class Calculator<T> where T: IAdditionOperators<T, T, T>
{
	public static T Add(T a, T b)
	{
		return a + b;
	}
}
class Car : IAdditionOperators<Car, Car, Car>
{
	public int price;
	public Car(int p)
	{
		price = p;
	}
	// ini namanya operator overloading, kita merubah format operator +
	// sehinnga bisa melakukan penjumlahan dengan class Car
	public static Car operator +(Car left, Car right)
	{
		return new Car(left.price + right.price);
	}
}