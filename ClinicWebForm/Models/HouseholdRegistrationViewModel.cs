using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    [NotMapped]
    public class HouseholdRegistrationViewModel
    {
        [Required]
        public virtual CHW CHW { get; set; }

        [Required]
        public virtual List<Clinic> Clinics { get; set; }

        [Required]
        public virtual List<Ward> Wards { get; set; }

        [Required]
        public virtual House House { get; set; }

        [Required]
        public virtual List<IndividualMember> Members { get; set; }

        [Required]
        public virtual List<Questions> Questions { get; set; }
    }
}