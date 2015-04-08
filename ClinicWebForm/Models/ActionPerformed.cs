using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class ActionPerformed
    {
        [Key]
        public int Id { get; set; }
        public string ActionPerformedDescription { get; set; }
        public bool Active { get; set; }
    }
}
