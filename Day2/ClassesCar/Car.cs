namespace CarsComponent;

public class Car
{
	public Break breaks;
	public Door door;
	public Engine engine;
	public Gas gas;
	public Seat seat;
	public Tire tire;
	
	public Car(Break breaks, Door door, Engine engine, Gas gas, Seat seat, Tire tire)
	{
		this.breaks = breaks;
		this.door = door;
		this.engine = engine;
		this.gas = gas;
		this.seat = seat;
		this.tire = tire;
	}
	
	public void EngineTest()
	{
		engine.EngineRun();
	}
}
