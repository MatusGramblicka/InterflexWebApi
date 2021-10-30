using System;

namespace InterflexWebApi.DTO
{
    public class Exchange
    {
        public string Subject { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
    }
}