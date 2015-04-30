using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public Questions Question { get; set; }
        public FormDocument FormDocument { get; set; }
        public string AnswerValue { get; set; }
    }
}