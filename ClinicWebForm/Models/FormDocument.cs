using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClinicWebForm.Models
{
    public class FormDocument
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Form Form { get; set; }

        [Required]
        public Clinic Clinic { get; set; }

        [Required]
        public Ward Ward { get; set; }

        [Required]
        public Province Province { get; set; }

        [Required]
        public Municipality Municipality { get; set; }

        [Required]
        public List<QuestionCategory> QuestionCategories { get; set; }
    }
}
