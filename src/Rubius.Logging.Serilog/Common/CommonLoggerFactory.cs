using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

namespace Rubius.Logging.Serilog.Common
{
    internal sealed class CommonLoggerFactory
    {
        private readonly IConfiguration _configuration;

        public CommonLoggerFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Создать логер с базовой конфигурацией
        /// </summary>
        /// <param name="outputTemplate">Шаблон сообщения, описывающий формат вывода</param>
        public Logger CreateCommonLogger(string outputTemplate = CommonLoggerConstants.OutputTemplateWithException)
        {
            return new LoggerConfiguration()
                .ReadFrom.Configuration(_configuration)
                .Enrich.FromLogContext()
                .WriteTo.Console(outputTemplate: outputTemplate)
                .CreateLogger();
        }
    }
}