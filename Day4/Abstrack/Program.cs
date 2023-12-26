using System;
class Program
{
	static void Main()
	{
		RumahBTN rumahBTN = new RumahBTN();
	}
}

/*
abstrak adalah salah satu sifat pemrograman OOP, dimana sebuah konsep
dari kelas atau method dapat dibangun jika masih belum jelas behaviour-nya.
class and method yang masih abstrack belum bisa digunakan.
jika ingin menggunakannya harus melengkapinya dahulu behaviour-nya.
cara melengakapinya dengan menghubungan dengan inheritance ke childnya lalu
childnya akan melengkapi kekurangan dari parentnya
*/
/*
konsep abstract sangat berguna jika kita mempunyai sebuah konsep atau
behaviournya terlalu umum dan akan menjadi spesifik jika
kita ingin menggunakannya

abstrack bisa memiliki field
interface tidak bisa memiliki field namun bisa memiliki properti

abstrack and interface have uncomplete method and must be completed by inheritance or get contract 
*/
abstract class Hunian
{
	public abstract void HowToSleep();
}
abstract class Rumah // abstract class dimana class ini belum bisa menjadi object
{
	public abstract void DoorSystem(); // abstract method belum bisa digunakan
}
// Childnya harus melengkapi kekurangan Parent
class RumahBTN : Hunian
{
	public override void HowToSleep()
	{
		Console.WriteLine("ZZzzz");
	}
}
class Gubug : Rumah
{
	public override void DoorSystem()
	{
		Console.WriteLine("Tanpa pintu");
	}
}