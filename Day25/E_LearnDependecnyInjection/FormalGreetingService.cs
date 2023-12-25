namespace E_LearnDependecnyInjection;

// Implementasi layanan penyapaan pertama
public class FormalGreetingService : IGreetingService
{
	public string Greet(string name)
	{
		return $"Selamat datang, {name}.";
	}
}