using System;
using System.Collections.Generic;

namespace AussieDivers.Models
{
    public partial class EquipmentHistory
    {
        public short EquipmentHistoryID { get; set; }
        public short EquipmentID { get; set; }
        public decimal EH_RetailCost { get; set; }
        public decimal EH_DatePurchased { get; set; }
        public virtual Equipment Equipment { get; set; }
    }
}
