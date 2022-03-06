using System;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    // Adapter class
    public class LogAdapter : ILogger
    {
        private readonly ILogNetMaster _logNetMaster;

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}
