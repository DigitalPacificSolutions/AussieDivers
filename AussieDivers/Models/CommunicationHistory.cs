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
    
    public partial class CommunicationHistory
    {
        public short NoteID { get; set; }
        public int PersonID { get; set; }
        public string CH_Comment { get; set; }
        public string CH_Status { get; set; }
        public string CH_Source { get; set; }
        public Nullable<System.DateTime> CH_Date { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
