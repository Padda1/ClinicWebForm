using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class Respondent
    {
        [Key]
        public int Id { get; set; }
        public string RespondentValue { get; set; }
        public bool Active { get; set; }
    }
}
