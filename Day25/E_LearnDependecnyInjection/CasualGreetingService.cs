namespace E_LearnDependecnyInjection;

// Implementasi layanan penyapaan kedua
public class CasualGreetingService : IGreetingService
{
	public string Greet(string name)
	{
		return $"Hai, {name}!";
	}
}