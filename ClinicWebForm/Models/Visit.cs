using System;
using System.Collections.Generic;

namespace ClinicWebForm.Models
{    
    public class Visit
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public virtual CHW CHW { get; set; }

        public virtual Visit PreviousVisits { get; set; }

        public virtual List<ActionPerformed> ActionsPerformed { get; set; }

        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.DateTime)]
        public DateTime VisitDate { get; set; }

        public virtual List<FormDocument> FormDocuments { get; set; }
    }
}
