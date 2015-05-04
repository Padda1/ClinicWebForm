using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class NextOfKin
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
    }
}
