namespace E_LearnDependecnyInjection;

// Kelas yang membutuhkan layanan penyapaan melalui DI
public class GreetingApp
{
	private readonly IGreetingService _greetingService;
	// private readonly GreetingService _greet

	// Konstruktor dengan DI
	public GreetingApp(IGreetingService greet)
	{
		_greetingService = greetingService;
	}

	// Metode untuk menyambut pengguna
	public void Run(string userName)
	{
		string greetingMessage = _greetingService.Greet(userName);
		Console.WriteLine(greetingMessage);
	}
}