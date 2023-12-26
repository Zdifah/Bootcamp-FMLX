using log4net;
using log4net.Config;

class Program
{
	private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
	static void Main()
	{
		XmlConfigurator.Configure(new FileInfo("MyConfigLog4Net.config"));
		
		for (int i = 0; i <=100000000; i++)
		{
			logger.Info("Info aja ya");
			logger.Debug("Debug aja ya");
			logger.Warn("Warning ya");
			logger.Error("Error aja ya");
			logger.Fatal("wih fatal nih");	
		}
	}
}