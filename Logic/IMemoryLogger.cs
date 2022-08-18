using EntryLogger.Models;

namespace EntryLogger.Logic;

public interface IMemoryLogger
{
    void LogMessage(LogEntry entry);
}