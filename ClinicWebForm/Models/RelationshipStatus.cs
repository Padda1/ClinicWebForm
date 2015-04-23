using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class RelationshipStatus
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(2)]
        [Display(Name = "Relationship Status")]
        public string StatusDescription { get; set; }

        public bool Active { get; set; }
    }
}
