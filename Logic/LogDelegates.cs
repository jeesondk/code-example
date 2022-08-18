using EntryLogger.Models;
using System.Linq;

namespace EntryLogger.Logic
{
    public static class LogDelegates
    {
        //public delegate void AddLogEntryDelegate(LogEntry entry);
        public static Action<LogEntry>? WriteMessage;

        public static Severity LogLevel { get; set; } = Severity.High;

        public static void LogMessage(LogEntry entry)
        {
            WriteMessage?.Invoke(entry);
        }

        public static void LogMessages(List<LogEntry> entries)
        {
            entries.ForEach(e => WriteMessage?.Invoke(e));
        }

    }
}
