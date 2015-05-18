using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    [NotMapped]
    public class ReferralViewModel
    {
        [Required]
        public virtual CHW CHW { get; set; }

        [Required]
        public virtual List<Clinic> Clinics { get; set; }

        [Required]
        public virtual List<Ward> Wards { get; set; }

        [Required]
        public virtual Referral Referral { get; set; }

        [Required]
        public virtual IndividualMember Member { get; set; }

        [Required]
        public virtual List<Questions> Questions { get; set; }
    }
}