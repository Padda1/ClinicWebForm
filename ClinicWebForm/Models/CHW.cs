﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class CHW
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApsNetUserId { get; set; }

        [Required]
        public string AspNetUserId { get; set; }

        public string HouseholdIdNName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(10)]
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
        public string Signature { get; set; }
    }
}
