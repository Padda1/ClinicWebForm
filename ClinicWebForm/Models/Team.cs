using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required]
        public List<CHW> CHWs { get; set; }

        [Required]
        public List<Household> Households { get; set; }
    }
}