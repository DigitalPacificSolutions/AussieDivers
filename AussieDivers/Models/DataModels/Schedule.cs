using System;
using System.Collections.Generic;

namespace AussieDivers.Models
{
    public partial class Schedule
    {
        public short ScheduleID { get; set; }
        public short BoatID { get; set; }
        public short DiveSiteID { get; set; }
        public string ScheduleDayOfWeek { get; set; }
        public virtual Boat Boat { get; set; }
        public virtual DiveSite DiveSite { get; set; }
    }
}
