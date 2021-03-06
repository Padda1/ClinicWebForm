﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class CHW
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Household Id Name")]
        public string HouseholdIdName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
        [Display(Name = "Household Id Number")]
        public string HouseholdIdNumber { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        [Display(Name = "CHW")]
        public string Signature { get; set; }

        [Display(Name = "Is Team Leader")]
        public bool IsTeamLeader { get; set; }
    }
}
