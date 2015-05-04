using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class IndividualMember
    {
        [Key]
        public int Id { get; set; }

        public virtual List<RelationshipStatus> RelationshipStatus { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Fullname")]
        public string FullName
        {
            get
            {
                return Name + " " + Surname;
            }
        }

        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Contact Number")]
        public string Tel { get; set; }

        [Display(Name = "BirthWeight")]
        public int BirthWeight { get; set; }

        [Display(Name = "Receiving Grant")]
        public bool ReceivingGrant { get; set; }

        [Display(Name = "Head Member")]
        public bool Head { get; set; }

        [Display(Name = "Is Referral")]
        public bool IsReferral { get; set; }
    }
}