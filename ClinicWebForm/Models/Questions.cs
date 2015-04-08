using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClinicWebForm.Models
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }
        public virtual QuestionCategory QuestionCategory { get; set; }
        public string QuestionDescription { get; set; }
        public bool Active { get; set; }
    }
}