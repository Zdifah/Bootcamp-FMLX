using PhotoFilterLib;
class Program
{
	/*
	implementasi delegate disini jika kita ada aplikasi untuk menerapkan filter pada
	foto. tapi karna filter yang kita inginkan tidak ada maka user harus menambahkannya
	. delegate memberikan kita fleksibilitas untuk tidak merubah class yang sudah kita buat
	
	*/
	static void Main()
	{
		/*
		teknis pengunaan delegate
		1. buat method delegatenya.
		2. subcriber yang mau join harus memiliki signature yang sama dengan publisher
		3. kita harus membuat variabel dengan tipe dari method delegate
		misal
		public delegate void Test(); --> method delegate
		
		Test masuk; --> variabel dari tipe method delegate
		
		masuk = (method yang ini kita masukin)
		*/
		var processor = new PhotoProcessor();
		var filters = new PhotoFilters();

		PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrigthness;

		processor.Process("photo.jpg", filterHandler);
	}
}