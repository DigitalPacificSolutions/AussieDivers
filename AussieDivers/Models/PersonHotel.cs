//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMVCSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonHotel
    {
        public short PersonHotelID { get; set; }
        public short HotelID { get; set; }
        public int BookingDetailsID { get; set; }
        public Nullable<short> PH_RoomNumber { get; set; }
        public string PH_RoomPhone { get; set; }
    
        public virtual BookingDetail BookingDetail { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
