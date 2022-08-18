using EntryLogger.Models;

namespace EntryLogger.Logic
{
    public class MemoryLogger
    {
        static List<LogEntry> internalEntries = new List<LogEntry>();

        public static void Run(LogEntry entry)
        {
            internalEntries.Add(entry);
        }
    }
}
