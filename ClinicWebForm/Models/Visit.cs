using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClinicWebForm.Models
{    
    public class Visit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public CHW CHW { get; set; }

        public int PreviousVisitId { get; set; }

        public virtual List<Visit> PreviousVisits { get; set; }

        public virtual ActionPerformed ActionPerformed { get; set; }

        public DateTime VisitDate { get; set; }
    }
}
