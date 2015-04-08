using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleDescription { get; set; }
    }
}
