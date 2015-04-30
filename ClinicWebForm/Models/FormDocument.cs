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

        public Form Form { get; set; }

        public Clinic Clinic { get; set; }

        public Ward Ward { get; set; }

        public Province Province { get; set; }

        public Municipality Municipality { get; set; }

        public Household Household { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
