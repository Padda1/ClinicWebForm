using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Province")]
        [MinLength(2)]
        public string ProvinceDescription { get; set; }

        public bool Active { get; set; }
    }
}