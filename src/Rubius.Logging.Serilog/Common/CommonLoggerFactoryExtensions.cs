using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Rubius.Logging.Serilog.Common
{
    internal static class CommonLoggerFactoryExtensions
    {
        public static ILoggingBuilder AddCommonLoggerFactory(this ILoggingBuilder builder)
        {
            builder.Services.AddSingleton<CommonLoggerFactory>();

            return builder;
        }
    }
}