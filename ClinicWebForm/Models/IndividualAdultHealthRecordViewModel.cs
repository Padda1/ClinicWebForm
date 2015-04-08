using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class IndividualAdultHealthRecordViewModel
    {
        [Required]
        public virtual CHW CHW { get; set; }

        [Required]
        public virtual Clinic Clinic { get; set; }

        [Required]
        public virtual Ward Ward { get; set; }

        [Required]
        public virtual Household Household { get; set; }

        [Required]
        public virtual NextOfKin NextOfKin { get; set; }

        [Required]
        public virtual IndividualMember Head { get; set; }

        [Required]
        public virtual List<Visit> Visits { get; set; }

        [Required]
        public virtual List<Referral> Referrals { get; set; }
    }
}