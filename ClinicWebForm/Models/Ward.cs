using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Ward
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string WardDescription { get; set; }

        public bool Active { get; set; }
    }
}