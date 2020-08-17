using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebPACS.Areas.Customer.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int CustomerID { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle name")]
        public string MiddleName { get; set; }

        [Display(Name = "Middle name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Father")]
        public bool is_Father { get; set; }

        [Display(Name = "First name ")]
        public string FatherFirstName{ get; set; }

        [Display(Name = "Middle name")]
        public string FatherMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string FatherLastName { get; set; }
       
        [Display(Name = "Father's age")]
        public DateTime? FatherAge{ get; set; }

        [Display(Name = "Mother")]
        public bool is_Mother { get; set; }

        [Display(Name = "First name ")]
        public string MotherFirstName { get; set; }

        [Display(Name = "Middle name")]
        public string MotherMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string MotherLastName { get; set; }

        [Display(Name = "Mother's age")]
        public DateTime? MotherAge { get; set; }

        [Display(Name = "Daughter_Of")]
        public bool is_Daughter { get; set; }

        [Display(Name = "First name ")]
        public string DaughterFirstName { get; set; }

        [Display(Name = "Middle name")]
        public string DaughterMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string DaughterLastName { get; set; }

        [Display(Name = "Daughter's age")]
        public DateTime? DaughterAge { get; set; }

        [Display(Name = "Son_Of")]
        public bool is_Son { get; set; }

        [Display(Name = "First name ")]
        public string SonFirstName { get; set; }

        [Display(Name = "Middle name")]
        public string SonMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string SonLastName { get; set; }

        [Display(Name = "son's age")]
        public DateTime? SonAge { get; set; }

        [Display(Name = "Spouse_Of")]
        public bool is_Spouse { get; set; }

        [Display(Name = "First name ")]
        public string SpouseFirstName { get; set; }

        [Display(Name = "Middle name")]
        public string SpouseMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string SpouseLastName { get; set; }

        [Display(Name = "Spouse's age")]
        public DateTime? SpouseAge { get; set; }

        [Display(Name = "Spouse's gender")]
        public string SpouseGender { get; set; }

        [Display(Name = "Gaurdian_Of")]
        public bool is_Gaurdian { get; set; }

        [Display(Name = "First name ")]
        public string GaurdianFirstName { get; set; }

        [Display(Name = "Middle name")]
        public string GaurdianMiddleName { get; set; }

        [Display(Name = "Last name")]
        public string GaurdianLastName { get; set; }

        [Display(Name = "Spouse's age")]
        public DateTime? GaurdianGender { get; set; }

        [Display(Name = "Mobile number")]
        public long? CustomerMobileNumber { get; set; }

        [Display(Name = "Alternative number")]
        public long? AlternativeContactNumber { get; set; }

        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }

        [Display(Name = "Caste")]
        public string CustomerCaste { get; set; }

        [Display(Name = "Sub Caste")]
        public string CustomerSubCaste { get; set; }

        [Display(Name = "Occupation")]
        public string Occupation { get; set; }

        [Display(Name = "Annual income")]
        public long? AnnualIncome { get; set; }

        [Display(Name = "AADHAR number")]
        public long? AADHARNo { get; set; }

        [Display(Name = "PAN number")]
        public string PAN { get; set; }

        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Display(Name = "Voter ID")]
        public string VoterID { get; set; }

        [Display(Name = "Ration card")]
        public string RationCard { get; set; }

        [Display(Name = "House number")]
        public string Housenumber { get; set; }

        [Display(Name = "Street")]
        public string street { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Maps link")]
        public string MapsLink { get; set; }

        [Display(Name = "Village/City")]
        public string Village_City { get; set; }

        [Display(Name = "Taluk")]
        public string Taluk { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }
      
        [Display(Name = "Pincode")]
        public int? Pincode { get; set; }

        //NOMINEE DETAILS
        [Display(Name = "Relation with customer")]
        public string RelationwithCustomer { get; set; }

        [Display(Name = "Nominee full name")]
        public string NomineeFullName { get; set; }

        [Display(Name = "Nominee DOB")]
        public DateTime? NomineeDOB { get; set; }

        [Display(Name = "Nominee address")]
        public string NomineeAddress{ get; set; }

        [Display(Name = "Nominee village")]
        public string NomineeVillage { get; set; }

        [Display(Name = "Nominee taluk")]
        public string NomineeTaluk{ get; set; }

        [Display(Name = "Nominee district")]
        public string NomineeDistrict{ get; set; }

        [Display(Name = "Nominee pincode")]
        public int? NomineePincode{ get; set; }

        [Display(Name = "Nominee contact number")]
        public int? NomineeContactNumber { get; set; }

        [Display(Name = "Minor")]
        public bool is_minor{ get; set; }

        [Display(Name = "Gaurdian full name")]
        public string GaurdianFullName { get; set; }

        [Display(Name = "Gaurdian DOB")]
        public DateTime? GaurdianDateofBirth { get; set; }

        [Display(Name = "Gaurdian address")]
        public string GaurdianAddress { get; set; }

        [Display(Name = "Gaurdian village")]
        public string GaurdianVillage { get; set; }

        [Display(Name = "Gaurdian taluk")]
        public string GaurdianTaluk { get; set; }

        [Display(Name = "Gaurdian district")]
        public string GaurdianDistrict { get; set; }

        [Display(Name = "Gaurdian pincode")]
        public int? GaurdianPincode { get; set; }

        [Display(Name = "Gaurdian contact number")]
        public int? GaurdianContactNumber { get; set; }

        public DateTime? ApplicationDateUpdated { get; set; }

        public DateTime? ApplicationDateCreated { get; set; }
    }
}
