namespace Rubius.Logging.Serilog.Common
{
    internal static class CommonLoggerConstants
    {
        /// <summary>
        /// Шаблон сообщения, описывающий формат без вывода исключения
        /// </summary>
        public const string OutputTemplateWithoutException =
            "[{Timestamp:yyyy-MM-dd:HH:mm:ss} {Level:u3}] [{SourceContext}] {Message:lj}{NewLine}";

        /// <summary>
        /// Шаблон сообщения, описывающий формат с выводом исключения
        /// </summary>
        public const string OutputTemplateWithException = OutputTemplateWithoutException + "{Exception}";
    }
}