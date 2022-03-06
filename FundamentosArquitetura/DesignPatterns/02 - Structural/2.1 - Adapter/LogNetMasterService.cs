using System;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    // Adaptee class
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}
