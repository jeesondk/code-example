using EntryLogger.Logic;
using EntryLogger.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static EntryLogger.Logic.LogDelegates;

namespace EntryLogger.Controllers
{
    [Route("api/logData")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private List<AddLogEntryDelegate> entryDelegate = new List<AddLogEntryDelegate>() { ConsoleOutput.Run, MemoryLogger.Run };

        [HttpPost]
        public ActionResult AddLogEntry(LogEntry entry)
        {
            foreach (var entryD in entryDelegate)
            {
                entryD(entry);
            }
            return NoContent();
        }

        [HttpPost("bulk")]
        public ActionResult AddLogEntries(List<LogEntry> entries)
        {
            foreach (var entry in entries)
            {
                AddLogEntry(entry);
            }
            return NoContent();
        }
    }
}
