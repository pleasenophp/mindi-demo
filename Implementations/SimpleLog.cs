using System;

namespace Custom.Demo.Implementations
{
    public class SimpleLog : ILog
    {
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}