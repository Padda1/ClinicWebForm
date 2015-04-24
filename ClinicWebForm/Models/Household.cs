using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Household
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="{0} is required.")]
        [MinLength(2)]
        [Display(Name = "Registration Number")]
        public string RegistrationNumber { get; set; }

        public virtual List<Visit> Visits { get; set; }
        
        public virtual Respondent Respondent { get; set; }

        [Required]
        [MinLength(2)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }

        [Display(Name = "All Members Registered")]
        public bool AllMembersRegistered { get; set; }

        [Display(Name = "Pregnancy Perion In 6 Weeks")]
        public bool PregnancyPerionIn6Weeks { get; set; }
        
        public virtual List<IndividualMember> Members { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }
    }
}