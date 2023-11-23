using System.Globalization;
using CarsComponent;

class Program
{
	static void Main()
	{
		Engine engine = new Engine()
		{
			brand = "Redbull",
			cylnder = 8,
			torque = 155.8f
		};
		
		Tire tire = new Tire()
		{
			brand = "Prilleri",
			colour = "Black",
			pressure = 15.6f
		};
		
		Seat seat = new Seat()
		{
			brand = "Pak Joko Luxury",
			totalSeat = 2	
		};
		
		Gas gas = new Gas()
		{
			brand = "Pertamina Tubro",
			octane = 99
		};
		
		Door door = new Door()
		{
			typeDoor = "slide",
			colour = "black"
		};
		
		Break breaks = new Break()
		{
			brand = "brembo",
			temperature = 99	
		};
		
		Car mobilBalap = new Car(breaks, door, engine, gas, seat, tire);
		mobilBalap.EngineTest();
	}
}