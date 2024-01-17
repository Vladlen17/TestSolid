using System;
using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{
    // Реализация логгера в консоль
    public class ConsoleLogger : ILogger
    {
        IDisposable ILogger.BeginScope<TState>(TState state)
        {
            return null;
        }

        bool ILogger.IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        void ILogger.Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            var message = formatter(state, exception);
            Console.WriteLine($"Logged message: {message}");
        }
    }
}
