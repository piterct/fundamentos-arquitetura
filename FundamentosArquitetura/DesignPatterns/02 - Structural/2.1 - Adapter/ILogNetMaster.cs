using System;

namespace DesignPatterns._02___Structural._2._1___Adapter
{
    public interface ILogNetMaster
    {
        void LogInfo(string message);
        void LogException(Exception exception);
    }
}
