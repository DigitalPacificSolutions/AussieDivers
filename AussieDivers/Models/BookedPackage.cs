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
    
    public partial class BookedPackage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookedPackage()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
        }
    
        public short BookedPackageID { get; set; }
        public short PackageID { get; set; }
        public short BookingID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Package Package { get; set; }
    }
}
