class Program 
{
	static void Main()
	{
		/*
		generic class dimana fieldnya atau parameter atau method yang bertipe T tidak
		dapat melakukan operasi logika karna tipe T belum jelas dia bertipe apa. walaupun
		kita sudah menetapakn class generic kita sebagai int tetap tidak bisa melakukan
		operasi logika
		*/
		CustomCollection<int> custom = new CustomCollection<int>(20);
		custom.Add(0, 1);
		custom.Add(1, 3);
		//custom.Add(2, "hello");
		int result = custom.GetValue(1);
		System.Console.WriteLine(result);
		
		CustomCollection<string> custom2 = new(2);
		custom2.Add(0,"a");
		
		GenericList<int> genericList = new();
		System.Console.WriteLine(genericList.Add<float>(9.89f));
		//genericList.Sum(10, 5);// --> disini akan eror
		genericList.Testing(10, 10); // --> disini akan eror
		
	}
}
/*
generic memberikan kita kemudahan dalam membuat collection yang safe type
seperti kita membuat kelas yang khusus menerima satu tipe data saja
karna kita mau fleksibilitas yang tinggi maka generic dapat membantu
pekerjaan anda
*/
// <T> --> tanda kalo class ini generic dan ketika dibuat instancenta
// ex CustomCollection<int> test = new(); --> T dapat diganti dengan
// berbagai macam tipe atau class
class CustomCollection<T>
{
	// kelasnya bertipe generic lalu fieldnya atau methodnya
	// bisa generic juga dengan manggantika tipe data dengan T
	// simbol <T> hanya untuk insialisasi 
	T[] myArray;
	public CustomCollection(int arraySize)
	{
		myArray = new T[arraySize];
	}
	public bool Add(int index, T x)
	{
		myArray[index] = x;
		return true;
	}
	public T GetValue(int index)
	{
		return myArray[index];
	}
}

// generic class
public class GenericList<T>
{
	// generic method, genericnya berbeda
	public U Add<U>(U a)
	{
		return a;
	}
	public T Sum(T a, T b)
	{
		return a + b;
	}
	public bool Testing(T a, T b)
	{
		if(a == b)
		{
			return true;
		}else
		{
			return false;
		}
	}
}