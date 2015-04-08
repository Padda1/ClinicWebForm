using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class QuestionCategory
    {
        [Key]
        public int Id { get; set; }
        public string CategoryDescription { get; set; }
        public bool Active { get; set; }
    }
}
