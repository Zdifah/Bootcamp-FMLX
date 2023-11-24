class Program
{
	static void Main()
	{
		/*
		implisit dan eksplisit adalah sebuah metode untuk melakukan konversi
		tipe data ke tipe data lainnya
		implisit --> tidak secara lugas ingin mengubah ke target mana
		eksplisit --> secara lugas ingin mengubah ke target mana
		*/
		//implisit
		int a = 10;
		long b = a;
		System.Console.WriteLine(b);
		
		//eksplisit
		int c = 50;
		long k = (long) c;
		System.Console.WriteLine(k);
		
		// konversi bisa menyebabkan data loss jadi jika dari tipe data besar ke kecil
		
		/*
		upcasting adalah perubahan tipe dari child ke parent
		*/
		Dog dog = new Dog();
		Animal animal = dog;
		
		/*
		downcasting adalah perubahan tipe parent ke chil
		*/
		Dog guguk = (Dog) animal;
	}
}

class Animal
{
	public Animal()
	{
		System.Console.WriteLine("animal terbentuk");
	}	
}
class Dog : Animal
{
	public Dog()
	{
		System.Console.WriteLine("Dog terbentuk");
	}
}