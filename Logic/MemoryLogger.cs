using EntryLogger.Models;

namespace EntryLogger.Logic
{
    public class MemoryLogger : IMemoryLogger
    {
        private readonly List<LogEntry> _internalEntries = new();

        public MemoryLogger()
        {
            LogDelegates.WriteMessage += LogMessage;
        }

        /*public static void Run(LogEntry entry)
        {
            internalEntries.Add(entry);
        }*/

        public void LogMessage(LogEntry entry)
        {
            _internalEntries.Add(entry);
        }
    }
}
