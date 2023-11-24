//Object
class Program {
	static void Main() {
		//Boxing
		int x = 3;
		object obj = x; // object seperti membungkus semua nilai
		//Unboxing
		int result = (int)obj; // kita harus membuka bungkus jika ingin digunakan
		Console.WriteLine(result);
		object y = 10;
		object hasil = y + x; // hasilnya eror jika kita maksa melukukan operasi pada object
		System.Console.WriteLine(hasil);
		
		//No need for cast, just unbox
		object obj1 = 3;
		double myDouble = (int)obj1;
		
		//Need for cast + unbox
		object obj2 = 3.0;
		int myInt = (int)(double)obj2;
	}
}