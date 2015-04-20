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
        public virtual CHW CHW { get; set; }

        public virtual Visit PreviousVisits { get; set; }

        public virtual List<ActionPerformed> ActionsPerformed { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime VisitDate { get; set; }

        public virtual List<FormDocument> FormDocuments { get; set; }
    }
}
