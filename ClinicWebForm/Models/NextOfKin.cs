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
        public string Name { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        public string ContactNumber { get; set; }
    }
}
