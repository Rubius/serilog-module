using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Extensions.Hosting;

namespace Rubius.Logging.Serilog.HttpRequest
{
    internal static class DiagnosticContextExtensions
    {
        public static ILoggingBuilder AddDiagnosticContext(this ILoggingBuilder builder)
        {
            builder.Services.AddSingleton(new DiagnosticContext(null));
            builder.Services.AddSingleton<IDiagnosticContext>(provider =>
                provider.GetRequiredService<DiagnosticContext>());

            return builder;
        }
    }
}