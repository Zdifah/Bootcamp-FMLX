namespace E_LearnDependecnyInjection;

// Kelas yang membutuhkan layanan penyapaan melalui DI
public class GreetingApp
{
	private readonly IGreetingService _greetingService;

	// Konstruktor dengan DI
	public GreetingApp(IGreetingService greetingService)
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