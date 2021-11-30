
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// DI, serilog, Settings

namespace ConsoleUI
{
    public class GreetingService : IGreetingService
    {
        // we do not modify the config and logs
        private readonly ILogger<GreetingService> _log;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> log, IConfiguration config)
        {
            _log = log;
            _config = config;
        }

        //public ILogger<GreetingService> Log { get; }

        public void Run()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _log.LogInformation("Run number {runNumber}", i);
            }
        }

    }

}
