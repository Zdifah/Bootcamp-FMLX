//Dynamic
// ! Dont use Dynamic in any case
// ! It will take so many process and hurts CPU
class Program
{
	static void Main()
	{
		/*
		dynamic bisa merubah tipe data pada saat run time sehingga
		dia dapat melakukan banyak perubahan dan akan memakan kemampuan CPU
		*/
		dynamic a = 3;
		a = "hello";
		a = true;
		// Var will check at compile time
		// Dynamic will check at running time
		// var a = new Car();
		a.Running(); // karna dynamic akan berubah pada runtime jadi dia juga bisa berubah menjadi instance dari kelass
		// ! Below will give exception
		a.Runninx();
		a.Meledak();
	}	
}


class Car {
	public void Running() {
		Console.WriteLine("Running");
	}
}

