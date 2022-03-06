using System;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    // Target class
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}
