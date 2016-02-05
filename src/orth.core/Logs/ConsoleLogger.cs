using System;

namespace Orth.Core.Logs
{
    /// <summary>
    /// Class implementing ILog to simply log to the Console
    /// </summary>
    public class ConsoleLogger : ILog
    {
        /// <summary>
        /// Logs the message to the Console
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
