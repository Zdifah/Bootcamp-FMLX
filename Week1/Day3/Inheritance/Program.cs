using AnimalKingdom;

class Program
{
	static void Main()
	{
		Cat cat = new Cat("jiji",true);
		Console.WriteLine(cat.name);	
		
		/*
		*pokoknya
		* Child child = new Child()
		* Parent parent = child --> ini bisa dilakuin karna child mempunyai struktur yang dibutuhkan jadi kelas Parent,
		*							tapi ga semua keunikan Child bisa diakses sama parent karna ga semua atribute Parent ada di Child
		*misal kaya kasus
		* Animal animal = cat
		* animal.Meow() --> kaya gini ga bisa
		* 
		*kalo ada kasus kaya gini
		* Animal animal = new Animal()
		* Cat cat = animal --> kaya gini ga bisa, karna ga semua atribut kelas Cat,
		*						dimiliki oleh kelas Animal, tapi kalo tetap ngotot mau dilakuin diperlukan cast ke kelas (Animal)
		*/
	}
}