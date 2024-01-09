using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Rubius.Logging.Serilog.Common;
using Serilog;
using Serilog.Core;

namespace Rubius.Logging.Serilog.Global
{
    internal static class GlobalLoggingExtensions
    {
        public static ILoggingBuilder AddGlobalLogging(this ILoggingBuilder builder)
        {
            Log.Logger = builder.CreateGlobalLogger();

            builder.ClearProviders()
                .AddSerilog(dispose: true);

            return builder;
        }

        private static Logger CreateGlobalLogger(this ILoggingBuilder builder)
        {
            return builder.Services
                .BuildServiceProvider()
                .GetRequiredService<CommonLoggerFactory>()
                .CreateCommonLogger();
        }
    }
}