using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public virtual CHW CHW { get; set; }
        public int PreviousVisitId { get; set; }
        public virtual ActionPerformed ActionPerformed { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
