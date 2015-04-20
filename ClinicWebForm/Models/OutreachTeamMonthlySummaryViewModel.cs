using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{

    public class OutreachTeamMonthlySummaryViewModel
    {
        [Required]
        public CHW CHW { get; set; }

        public Clinic Clinic { get; set; }

        public Ward Ward { get; set; }

        public Team Team { get; set; }
    }
}