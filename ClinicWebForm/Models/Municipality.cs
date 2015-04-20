using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Municipality
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Municipal Code")]
        [MinLength(2)]
        public string MunicipalCode { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Municipal Name")]
        [MinLength(2)]
        public string MunicipalName { get; set; }
    }
}