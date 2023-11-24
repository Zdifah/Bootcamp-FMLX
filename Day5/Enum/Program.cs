class Program
{
	static void Main()
	{
		/*
		enum adalah sekumpulan data yang secara khusus akan mewakili nilai-
		nilai.
		*/
		
		MonthOfYear month = MonthOfYear.Agustus; // output tipe data enum value Agustus
		// kalo dijadiin string bisa diubah jadi .ToString();
		System.Console.WriteLine(month);
		// atau juga kita bisa mengakses keyword enumnya dari sini
		int count = 1;
		MonthOfYear coba = (MonthOfYear) count; // output january
		System.Console.WriteLine(coba);
		
		// kita bisa mengakses nilai dari masing-masing data
		int get = (int) MonthOfYear.January; // output 1
		System.Console.WriteLine(get);
		
	}
}

// cara deklarasi enum
enum MonthOfYear
{
	January = 1,
	February = 2,
	Maret = 3,
	April = 4,
	Mei = 5,
	Juni = 6,
	Juli = 7,
	Agustus = 8,
	September = 9,
	October = 10,
	November = 11,
	Desember = 12
}
