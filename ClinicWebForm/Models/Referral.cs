using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class Referral
    {
        [Key]
        public int Id { get; set; }

        public virtual Visit Visit { get; set; }
        public virtual ReferralReason ReferralReason { get; set; }
        public virtual ReferralOutcome ReferralOutcome { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Referred To")]
        public string ReferredTo { get; set; }

        [Required(ErrorMessage="{0} is required.")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [Display(Name = "Back Referral Received")]
        public DateTime BackReferralReceived { get; set; }
    }
}
