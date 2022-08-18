using System.ComponentModel.DataAnnotations;

namespace EntryLogger.Models
{
    public class LogEntry
    {
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public int TraceId { get; set; }
        [Required]
        public Severity Severity { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        public string Message { get; set; }
        public string ComponentName { get; set; }
        public int RequestId { get; set; }

    }
}
