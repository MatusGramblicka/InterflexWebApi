using System.Collections.Generic;

namespace InterflexWebApi.DTO
{
    public class DayAndTime
    {
        public string Day { get; set; }
        public string ActualTime { get; set; }
        public List<AbsenceReason> AbsenceReasons { get; set; }
    }
}
