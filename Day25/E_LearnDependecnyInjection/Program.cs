using E_LearnDependecnyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
	static void Main()
	{
		IServiceCollection service = new ServiceCollection();
		service.AddTransient<IGreetingService, FormalGreetingService>();
		service.AddTransient<IGreetingService, CasualGreetingService>();
		service.AddTransient<GreetingApp>();
		
		IServiceProvider provider = service.BuildServiceProvider();
		
		GreetingApp greetingAppFormal = provider.GetRequiredService<GreetingApp>();
		GreetingApp greetingAppCasual = provider.GetRequiredService<GreetingApp>();
		
		greetingAppCasual.Run("Ilham");
		greetingAppFormal.Run("Fahry");
		FormalGreetingService formal = new();
		CasualGreetingService casual = new();
		
		GreetingApp app = new GreetingApp(casual);
		
		
	}
}
