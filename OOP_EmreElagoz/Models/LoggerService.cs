using System;
namespace OOP_EmreElagoz.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;
        public static LogMessage[] Logs
        {
            get
            {
                return logs;
            }
        }
        public static void AddLogMessage(LogMessage logMessage)
        {
            Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = logMessage;
        }
        static LoggerService()
        {
            logs = new LogMessage[0];
        }
    }
}
