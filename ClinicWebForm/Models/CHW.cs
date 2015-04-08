using System;
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
        public string HouseholdIdNumber { get; set; }
        public string Name { get; set; }
    }
}
