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
        public string ReferredTo { get; set; }
        public DateTime BackReferralReceived { get; set; }
    }
}
