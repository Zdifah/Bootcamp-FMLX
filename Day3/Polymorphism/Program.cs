using MethodHiding;
using Overloading;
using VirtualAndOverride;

class Program
{
	static void Main()
	{
		/*
		Polymorphism adalah salah satu sebuah sifat pemrograman oop dimana
		dalam setiap mendeklar kelas atau metode memungkinkan membuatnya menjadi prilaku
		atau bentuk yang berbeda.
		terdapat 2 jenis polymorphism
		1. Overloading --> memungkin kita membuat lebih dari 1 construction atau method
		   dengan nama yang sama namun dengan parameter yang berbeda (membuatnya beda 
		   atau tidak HANYA DI PARAMETERNYA SAJA) 
		2. Overriding --> memungkin kita mengguna method yang sama dari Pareng yang akan
		   akan digunaka oleh Child yang dimana method yang dibutuhkan oleh Child
		   berisi kegiatan yang berbeda dari method Parent namun diakses dengan nama method
		   yang sama.
		   OVerriding di bagi jadi 2 jenis
		   2.1. virtual and override --> method Parent akan di pasang virtual keyword. method yang dipasang virutal keyword
				akan menurunkan methodnya ke method Child yang sudah terpasang override keyword. dimana method Child tersebut
				dapat mengubah method Parent menjadi sesuai kebutuhannya. metode overriding ini jika kita lihat dari sudut pandang
				memori. method parent yang diturunkan ke method child akan diubah secara memori.
		   2.2. method hiding --> method hiding memiliki tujuan yang sama seperti virtual and override, namun yang membedakannya adalah
		   		method Parent yang asli tidak hilang jika methodnya digunakan ke child yang mana ia akan mengubah
				method aslinya
		*/
		
		// overloading
		Calculator calc1 = new Calculator();
		// Console.WriteLine(calc1.Add(1,2));
		// Console.WriteLine(calc1.Add(1,2,3));
		
		Calculator calc2 = new Calculator(1,2);
		
		Calculator calc3 = new Calculator(1,2,3);
		
		//overriding
		//virtual and override
		Parent parent = new Parent();
		parent.Job();
		Child child = new Child();
		child.Job();
		parent.Job();
		
		//override
		Cat cat = new Cat();
		cat.MakeSound();
		
		Animal animal = new Animal();
		animal.MakeSound();
	}
}