using System;
using System.Collections.Generic;

namespace AussieDivers.Models
{
    public partial class Payment
    {
        public short PaymentID { get; set; }
        public short BookingID { get; set; }
        public decimal PaymentAmount { get; set; }
        public decimal PaymentBalance { get; set; }
        public short MethodID { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
