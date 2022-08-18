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
        
        //private List<AddLogEntryDelegate> entryDelegate = new List<AddLogEntryDelegate>() { ConsoleOutput.Run, MemoryLogger.Run };
        private IConsoleOutput _consoleOutput;
        private IMemoryLogger _memoryLogger;

        public LogController(IConsoleOutput consoleOutput, IMemoryLogger memoryLogger)
        {
            _consoleOutput = consoleOutput;
            _memoryLogger = memoryLogger;
        }

        [HttpPost]
        public ActionResult AddLogEntry(LogEntry entry)
        {
            /*
            foreach (var entryD in entryDelegate)
            {
                entryD(entry);
            }
            return NoContent();*/

            LogMessage(entry);
            return Ok();
        }

        [HttpPost("bulk")]
        public ActionResult AddLogEntries(List<LogEntry> entries)
        {
            /*foreach (var entry in entries)
            {
                AddLogEntry(entry);
            }
            return NoContent();*/
            
            LogMessages(entries);
            return Ok();
        }
    }
}
