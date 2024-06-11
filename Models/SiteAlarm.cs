namespace us3.Models
{
    public class SiteAlarm
    {
        public string? Site { get; set; }
        public string? TimeStamp { get; set; }
        public string? Message { get; set; }
        public bool Ack { get; set; }
        public string? Note { get; set; }
    }
}
