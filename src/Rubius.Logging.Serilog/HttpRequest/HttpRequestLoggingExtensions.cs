using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Rubius.Logging.Serilog.Common;
using Serilog;
using Serilog.AspNetCore;
using Serilog.Core;

namespace Rubius.Logging.Serilog.HttpRequest
{
    internal static class HttpRequestLoggingExtensions
    {
        public static IApplicationBuilder UseHttpRequestLogging(
            this IApplicationBuilder app,
            Action<RequestLoggingOptions> configureOptions = null)
        {
            return app.UseSerilogRequestLogging(options =>
            {
                options.Logger = app.CreateHttpRequestLogger();
                configureOptions?.Invoke(options);
            });
        }

        private static Logger CreateHttpRequestLogger(this IApplicationBuilder app)
        {
            return app.ApplicationServices
                .GetRequiredService<CommonLoggerFactory>()
                .CreateCommonLogger(CommonLoggerConstants.OutputTemplateWithoutException);
        }
    }
}