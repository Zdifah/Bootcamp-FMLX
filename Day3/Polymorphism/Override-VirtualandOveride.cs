namespace VirtualAndOverride;

public class Parent
{
	public string name;
	public int age;
	
	public virtual void Job()
	{
		Console.WriteLine("KERJA KERJA KERJA");
	}
}

public class Child : Parent
{
	public override void Job()
	{
		Console.WriteLine("Masih sekolah om!!");	
	}
}
