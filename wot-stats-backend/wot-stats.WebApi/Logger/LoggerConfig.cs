using Serilog;

namespace wot_stats.WebApi.Logger
{
    public static class LoggerConfig
    {
        public static Serilog.Core.Logger GetLoggerConfiguration() =>
            new LoggerConfiguration().MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
            .WriteTo.File("backendLog-.txt", rollingInterval: RollingInterval.Hour)
            .CreateLogger();
    }
}
