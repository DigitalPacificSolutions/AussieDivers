using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AussieDivers.Models
{
    public partial class Person
    {
        public Person()
        {
            this.BookingDetails = new List<BookingDetail>();
            this.CommunicationHistories = new List<CommunicationHistory>();
            this.DiveHistories = new List<DiveHistory>();
            this.EmergencyContacts = new List<EmergencyContact>();
            this.PersonCertifications = new List<PersonCertification>();
        }

        public int PersonID { get; set; }

        [Display(Name = "First Name")]
        public string PersonFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string PersonLastName { get; set; }

        [Display(Name = "Email")]
        public string PersonEmail { get; set; }

        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> PersonDOB { get; set; }

        [Display(Name = "Last Dive Date")]
        public Nullable<System.DateTime> PersonLastDiveDate { get; set; }

        [Display(Name = "Number of Dives")]
        public Nullable<short> PersonNumberOfDives { get; set; }

        [Display(Name = "Street Address 1")]
        public string PersonStreetAddress1 { get; set; }

        [Display(Name = "Street Address 2")]
        public string PersonStreetAddress2 { get; set; }

        [Display(Name = "City")]
        public string PersonCity { get; set; }

        [Display(Name = "State / Territory")]
        public string PersonStateProvinceTerritory { get; set; }

        [Display(Name = "Country")]
        public string PersonCountry { get; set; }

        [Display(Name = "Postal Code")]
        public string PersonPostalCode { get; set; }

        [Display(Name = "Phone")]
        public string PersonPhone { get; set; }

        [Display(Name = "Vegetarian")]
        public string PersonVegetarian { get; set; }

        [Display(Name = "Allergies")]
        public string PersonAllergies { get; set; }

        public byte[] PersonPhoto { get; set; }
        public System.DateTime PersonLastUpdated { get; set; }
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual ICollection<CommunicationHistory> CommunicationHistories { get; set; }
        public virtual ICollection<DiveHistory> DiveHistories { get; set; }
        public virtual ICollection<EmergencyContact> EmergencyContacts { get; set; }
        public virtual ICollection<PersonCertification> PersonCertifications { get; set; }
    }
}
