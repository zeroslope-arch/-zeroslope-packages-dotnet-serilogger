using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace ZeroSlope.Packages.DotNet.Serilogger.Installers
{
    public class SeriloggerInstaller
    {
		public SeriloggerInstaller()
        {

        }

		public void Install(IServiceCollection serviceCollection)
		{
			var logger = new LoggerConfiguration()
				.WriteTo
				.Console()
				.CreateLogger();
			serviceCollection.AddSingleton<ILogger>(logger);
		}
	}
}
