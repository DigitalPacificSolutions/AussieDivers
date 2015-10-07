using System;
using System.Collections.Generic;

namespace AussieDivers.Models
{
    public partial class DiveHistory
    {
        public short DiveHistoryID { get; set; }
        public short DiveSiteID { get; set; }
        public int PersonID { get; set; }
        public virtual DiveSite DiveSite { get; set; }
        public virtual Person Person { get; set; }
    }
}
