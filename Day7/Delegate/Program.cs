// cara mendeklarasi delegate
public delegate void MyDelegate();
class Program
{
	/*
	delegate adalah fitur dimana kita dapat mewekili sebuah method.
	dengan syarat method itu memiliki signature yang sama.
	pada MyDelegate() memiliki signature berupa void dan parameterless
	*/
	static void Main()
	{
		// cara memanggil delegate
		MyDelegate myDelegate;
		// cara menambahkan method ke dalam delegate
		myDelegate = Displayer;
		myDelegate += Testing;
		// jika kita ingin mengurangi method di myDelegate dapat melakukan
		// cara ini -=
		
		// cara memanggil method yang berapa di delegate
		myDelegate.Invoke();
		/*
		pada penerapan delegate terdapat konsep berupa Subcriber dan Publisher
		dimana analogi ini berupa beberapa banyak class atau method akan meng-Subcrib
		si Publisher sehingga dari class atau method yang telah mendaftar
		jika suatu saat si publisher akan menggunakan memanggil method yang
		terdaftar dan semuanya akan terpanggil
		*/
		/*
		kelebihan delegate adalah dapat menyambungkan semua class atau method
		dari manapun di satu tempat dengan syarat signature harus sama.
		jadi jika kita punya class A, class B, dan class C. masing-masing
		class tersebut terdapat method yang memiliki signature serupa dengan 
		delegate (publisher), maka method tersebut dapat dimasukan 
		(subscriber) ke dalam publisher.
		*/
	}
	static void Displayer()
	{
		System.Console.WriteLine("Displayer");
	}
	static void Testing()
	{
		System.Console.WriteLine("testing");
	}
}