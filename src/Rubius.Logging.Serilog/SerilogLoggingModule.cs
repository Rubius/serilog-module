using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Rubius.Logging.Serilog.Common;
using Rubius.Logging.Serilog.Global;
using Rubius.Logging.Serilog.HttpRequest;
using Serilog.AspNetCore;

namespace Rubius.Logging.Serilog
{
    public static class SerilogLoggingModule
    {
        public static ILoggingBuilder AddSerilogLoggingModule(this ILoggingBuilder builder)
        {
            builder.AddCommonLoggerFactory();
            builder.AddGlobalLogging();
            builder.AddDiagnosticContext();

            return builder;
        }

        public static IApplicationBuilder UseSerilogHttpRequestLoggingModule(
            this IApplicationBuilder app,
            Action<RequestLoggingOptions> configureOptions = null)
        {
            return app.UseHttpRequestLogging(configureOptions);
        }
    }
}