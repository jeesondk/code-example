using EntryLogger.Models;
using System.Diagnostics;
using static EntryLogger.Logic.LogDelegates;

namespace EntryLogger.Logic
{
    public class ConsoleOutput
    {
        public static AddLogEntryDelegate Run = (LogEntry entry) =>
        {
            List<string> data = new List<string>();
            data.Add(entry.ApplicationId.ToString());
            data.Add(entry.TraceId.ToString());
            data.Add(entry.Severity.ToString());
            data.Add(entry.TimeStamp.ToString());
            data.Add(entry.Message.ToString());
            data.Add(entry.RequestId.ToString());

            Debug.WriteLine(string.Join("\t", data));

        };
    }
}
