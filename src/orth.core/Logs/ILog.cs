using System;

namespace Orth.Core.Logs
{
    /// <summary>
    /// Interface for Logging
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Logs the passed string. 
        /// </summary>
        /// <param name="message">The Message to Log</param>
        void Log(string message);
    }
}
