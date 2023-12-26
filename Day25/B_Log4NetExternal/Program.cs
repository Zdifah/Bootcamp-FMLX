﻿using System;
using log4net;
using log4net.Config;

namespace Log4NetExample
{
	class Program
	{
		// Create an instance of the logger
		private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

		static void Main(string[] args)
		{
			// use external configuration log4net
			XmlConfigurator.Configure(new FileInfo("MyLog4Net.config"));
			logger.Debug("This is a debug message");
			logger.Info("This is an info message");
			logger.Warn("This is a warning message");
			logger.Error("This is an error message");
			logger.Fatal("This is a fatal message");
			GameRunner.Message("This is GAMERUNNER");
		}
	}
	
	class GameRunner
	{
		private static readonly ILog logger = LogManager.GetLogger(typeof(GameRunner));
		public static void Message(string args)
		{
			logger.Info(args);
		}

	}
}