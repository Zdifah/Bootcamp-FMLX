using System;
class Program
{
	static void Main()
	{
		Electrician electrician = new Electrician();
		electrician.DoingJob();
	}
}
/*
Interface sangat berguna jika ingin menghubungankan sebuah class yang tidak
berkolerasi namun memiliki fungsi yang serupa
interface tidak bisa membuat field di dalam kelasnya
*/


interface INut
{
	void OpenedNut();
}
interface ICabel
{
	void Wiring();
}
interface ICNC
{
	void Bubut();
}

abstract class Job
{
	public abstract void DoingJob();
}

class Electrician : Job, INut, ICabel
{
	public override void DoingJob()
	{
		OpenedNut();
		Wiring();
	}
	public void OpenedNut()
	{
		Console.WriteLine("Buka baut untuk masang kabel");
	}
	public void Wiring()
	{
		Console.WriteLine("Nyusun Kabel jadi rangkaian listrik");
	}
}

class Mechanics : INut, ICNC
{
	public void OpenedNut()
	{
		Console.WriteLine("Buka baut tergantun jenis dan ukurannya");
	}
	public void Bubut()
	{
		Console.WriteLine("Ngebubut dulu pak!");
	}
}

class NetworkTechnician : ICabel
{
	public void Wiring()
	{
		Console.WriteLine("Masang wifi");
	}
}