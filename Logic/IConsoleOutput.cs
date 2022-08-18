using EntryLogger.Models;

namespace EntryLogger.Logic;

public interface IConsoleOutput
{
    void LogMessage(LogEntry entry);
}