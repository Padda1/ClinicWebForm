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
        public string AspNetUserId { get; set; }

        public string HouseholdIdNumber { get; set; }
        
        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Surname { get; set; }
    }
}
