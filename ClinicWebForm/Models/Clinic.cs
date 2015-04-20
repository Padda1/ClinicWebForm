using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Clinic
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Clinic")]
        public string ClinicDescription { get; set; }

        public bool Active { get; set; }
    }
}